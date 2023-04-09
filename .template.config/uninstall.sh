#!/usr/bin/env bash
base_root="$HOME/.dotnet/custom_templates"
template_root="$base_root/Base.Clean.Template"

clean_echo() {
    command printf %s\\n "$*" 2>/dev/null
}

uninstall_template(){
    dotnet new uninstall $template_root
    clean_echo "Clean Architecture API template uninstalled..."
    clean_echo "Removing template folder"
    rm -rf $template_root
    clean_echo "Uninstallation finished..."
}

uninstall_template
