#!/usr/bin/env bash
root="$HOME/.dotnet/custom_templates/Base.Clean.Template"
git_repo="https://github.com/caikmoraes/CleanArchitectureDotnetTemplate.git"

clean_echo() {
    command printf %s\\n "$*" 2>/dev/null
}


create_dir() {
    clean_echo "Creating directories..."
    mkdir $root
}

move_and_clone() {
    clean_echo "Cloning template..."
    git clone $git_repo $root
}

install_template(){
    dotnet new install $root
    clean_echo "Instalation finished..."
    clean_echo "To check instalation run try 'dotnet new list | grep cleanarch'"
}

create_dir

move_and_clone

install_template
