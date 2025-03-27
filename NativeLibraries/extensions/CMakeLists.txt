cmake_minimum_required(VERSION 3.1)

project(../cimgui)

set(CMAKE_CXX_STANDARD 11)
set(CMAKE_CXX_STANDARD_REQUIRED True)
add_definitions("-DIMGUI_USER_CONFIG=\"../cimconfig.h\"")


add_library(cimplot SHARED
    ../cimgui/imgui/imgui.cpp
    ../cimgui/imgui/imgui_draw.cpp
    ../cimgui/imgui/imgui_demo.cpp
    ../cimgui/imgui/imgui_widgets.cpp
	../cimgui/imgui/imgui_tables.cpp
    cimplot/cimplot.cpp
    cimplot/implot/implot.cpp
    cimplot/implot/implot_demo.cpp
    cimplot/implot/implot_items.cpp)


target_compile_definitions(cimplot PUBLIC IMGUI_DISABLE_OBSOLETE_FUNCTIONS=1)
target_include_directories(cimplot PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimplot/implot)
target_include_directories(cimplot PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/../cimgui/imgui)
target_include_directories(cimplot PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/../cimgui)
set_target_properties(cimplot PROPERTIES PREFIX "")


add_library(cimnodes SHARED
    ../cimgui/imgui/imgui.cpp
    ../cimgui/imgui/imgui_draw.cpp
    ../cimgui/imgui/imgui_demo.cpp
    ../cimgui/imgui/imgui_widgets.cpp
	../cimgui/imgui/imgui_tables.cpp
    cimnodes/cimnodes.cpp
    cimnodes/imnodes/imnodes.cpp)

target_compile_definitions(cimnodes PRIVATE IMNODES_NAMESPACE=imnodes IMGUI_DISABLE_OBSOLETE_FUNCTIONS=1)
target_include_directories(cimnodes PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimnodes/imnodes)
target_include_directories(cimnodes PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/../cimgui/imgui)
target_include_directories(cimnodes PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/../cimgui)
set_target_properties(cimnodes PROPERTIES PREFIX "")


add_library(cimguizmo SHARED
    ../cimgui/imgui/imgui.cpp
    ../cimgui/imgui/imgui_draw.cpp
    ../cimgui/imgui/imgui_demo.cpp
    ../cimgui/imgui/imgui_widgets.cpp
	../cimgui/imgui/imgui_tables.cpp
    cimguizmo/cimguizmo.cpp
    cimguizmo/ImGuizmo/ImGuizmo.cpp)

target_compile_definitions(cimguizmo PUBLIC IMGUI_DISABLE_OBSOLETE_FUNCTIONS=1)
target_include_directories(cimguizmo PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/cimguizmo/imguizmo)
target_include_directories(cimguizmo PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/../cimgui/imgui)
target_include_directories(cimguizmo PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/../cimgui)
set_target_properties(cimguizmo PROPERTIES PREFIX "")
