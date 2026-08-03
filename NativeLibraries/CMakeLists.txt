# This CMake build cimgui and all extensions in a single library
cmake_minimum_required(VERSION 3.10)
project(cimgui)
set(CMAKE_CXX_STANDARD 11)
set(CMAKE_CXX_STANDARD_REQUIRED True)

option(CIMGUI_INCLUDE_DEMOS "Include ImGui demo files" ON)

set(SOURCES
    cimgui/cimgui.cpp
    cimgui/imgui/imgui.cpp
    cimgui/imgui/imgui_draw.cpp
    cimgui/imgui/imgui_widgets.cpp
    cimgui/imgui/imgui_tables.cpp

    cimplot/cimplot.cpp
    cimplot/implot/implot.cpp
    cimplot/implot/implot_items.cpp

    cimnodes/cimnodes.cpp
    cimnodes/imnodes/imnodes.cpp

    cimguizmo/cimguizmo.cpp
    cimguizmo/ImGuizmo/ImGuizmo.cpp
    cimguizmo/ImGuizmo/GraphEditor.cpp
    cimguizmo/ImGuizmo/ImCurveEdit.cpp
    cimguizmo/ImGuizmo/ImGradient.cpp
    cimguizmo/ImGuizmo/ImSequencer.cpp
)
if(CIMGUI_INCLUDE_DEMOS)
    set(SOURCES ${SOURCES} cimplot/implot/imgui_demo.cpp)
    set(SOURCES ${SOURCES} cimplot/implot/implot_demo.cpp)
endif()

add_library(cimgui SHARED
    cimgui/cimgui.cpp
    cimgui/imgui/imgui.cpp
    cimgui/imgui/imgui_draw.cpp
    cimgui/imgui/imgui_demo.cpp
    cimgui/imgui/imgui_widgets.cpp
	cimgui/imgui/imgui_tables.cpp
    
    cimplot/cimplot.cpp
    cimplot/implot/implot.cpp
    cimplot/implot/implot_demo.cpp
    cimplot/implot/implot_items.cpp
    
    cimnodes/cimnodes.cpp
    cimnodes/imnodes/imnodes.cpp

    cimguizmo/cimguizmo.cpp
    cimguizmo/ImGuizmo/ImGuizmo.cpp
    cimguizmo/ImGuizmo/GraphEditor.cpp
    cimguizmo/ImGuizmo/ImCurveEdit.cpp
    cimguizmo/ImGuizmo/ImGradient.cpp
    cimguizmo/ImGuizmo/ImSequencer.cpp
)

# FreeType. build.py has always passed -DIMGUI_FREETYPE, and nothing here read it, so
# the option was accepted and ignored: imgui_freetype.cpp was never compiled and the
# three ImGuiFreeType_* functions the generator emits were exported by no platform.
# Every call to them threw, on all seven.
option(IMGUI_FREETYPE "Build the FreeType font rasteriser" OFF)

if(IMGUI_FREETYPE)
    if(EMSCRIPTEN)
        # Emscripten ships FreeType as a port, so there is nothing to find: the flag
        # both compiles it and links it.
        target_compile_options(cimgui PRIVATE -sUSE_FREETYPE=1)
        target_link_options(cimgui PRIVATE -sUSE_FREETYPE=1)
    else()
        find_package(Freetype REQUIRED)
        target_link_libraries(cimgui PRIVATE Freetype::Freetype)
    endif()
    target_sources(cimgui PRIVATE cimgui/imgui/misc/freetype/imgui_freetype.cpp)
    # Both loaders, deliberately. imgui guards each behind its own flag, and defining
    # only IMGUI_ENABLE_FREETYPE drops the stb_truetype one -- while cimgui still emits
    # a wrapper calling ImFontAtlasGetFontLoaderForStbTruetype, so the library stops
    # compiling. That is what the first attempt at this did.
    #
    # Keeping both is also what a binding wants: ImGuiFreeType_GetFontLoader exists so
    # the consumer can choose at runtime, which requires both to be present.
    target_compile_definitions(cimgui PRIVATE IMGUI_ENABLE_FREETYPE IMGUI_ENABLE_STB_TRUETYPE)
endif()

target_compile_definitions(cimgui PRIVATE IMNODES_NAMESPACE=imnodes IMGUI_DISABLE_OBSOLETE_FUNCTIONS=1 CIMGUI_VARGS0)
target_include_directories(cimgui PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimgui)
target_include_directories(cimgui PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimgui/imgui)
target_include_directories(cimgui PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimplot)
target_include_directories(cimgui PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimplot/implot)
target_include_directories(cimgui PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimnodes)
target_include_directories(cimgui PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimnodes/imnodes)
target_include_directories(cimgui PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimguizmo)
target_include_directories(cimgui PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimguizmo/imguizmo)