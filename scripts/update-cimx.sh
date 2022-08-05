#!/bin/bash
set -e

################################################################################
# Updates cimX definitions and native libraries.
#
# This script updates cimX definitions and native libraries only if there are changes in the native submodules.

# CONFIG
buildConfig="Release"

archs=('x86', 'x64') #, 'ARM', 'ARM64')
extensions=("imguizmo" "imnodes" "implot")
SCRIPT_DIR=$( cd -- "$( dirname -- "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )

# Aux functions to improve outputs
pushd () {
    command pushd "$@" > /dev/null
}
popd () {
    command popd "$@" > /dev/null
}


# Set working directory
pushd $SCRIPT_DIR
cd $SCRIPT_DIR/../NativeLibraries

# update cimgui & register for build if changes
pushd "./cimgui"
currentRef=$(git rev-parse HEAD)
git pull origin master > /dev/null 2>&1
if [[ $(git rev-parse HEAD) != $currentRef ]]
then
  echo "cimgui has been updated."
  echo "::set-output name=BUILD_CIMGUI::true"
else
  echo "cimgui already up to date."
  echo "::set-output name=BUILD_CIMGUI::false"
fi
popd

# update submodules & register for build if changes
buildExtensions=false
for extension in "${extensions[@]}"
do
  pushd "./extensions/c$extension"
  currentRef=$(git rev-parse HEAD)
  git pull origin master > /dev/null 2>&1
  if [[ $(git rev-parse HEAD) != $currentRef ]]
  then
    echo "$extension has been updated."
    buildExtensions=true
    echo "::set-output name=BUILD_CIMGUI::true"
  else
    echo "$extension already up to date."
    echo "::set-output name=BUILD_CIMGUI::false"
  fi
  popd
done

if [ "$buildExtensions" = true ]
  then
    echo "::set-output name=BUILD_EXT::true"
  else
    echo "::set-output name=BUILD_EXT::false"
  fi

popd
