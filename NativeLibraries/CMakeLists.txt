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

target_compile_definitions(cimgui PRIVATE IMNODES_NAMESPACE=imnodes IMGUI_DISABLE_OBSOLETE_FUNCTIONS=1)
target_include_directories(cimgui PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimgui)
target_include_directories(cimgui PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimgui/imgui)
target_include_directories(cimgui PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimplot)
target_include_directories(cimgui PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimplot/implot)
target_include_directories(cimgui PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimnodes)
target_include_directories(cimgui PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimnodes/imnodes)
target_include_directories(cimgui PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimguizmo)
target_include_directories(cimgui PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimguizmo/imguizmo)
