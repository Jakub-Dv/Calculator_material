project(Calculator_material LANGUAGES CSharp)


add_library(mylib SHARED
	${CMAKE_CURRENT_SOURCE_DIR}/MaterialDesignColors.dll
	${CMAKE_CURRENT_SOURCE_DIR}/MaterialDesignThemes.Wpf.dll)
SET_TARGET_PROPERTIES(mylib PROPERTIES LINKER_LANGUAGE CSharp)
