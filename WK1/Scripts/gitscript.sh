#!/usr/bin/bash


#Promt the user
echo "enter the file you would like to add"

#accept user input
read name


#Filter only .txt, .md, .sh, .png files

#save the extension abreviation as ext
ext+"${name##*.}"

if (( $ext == "txt" || $ext == "md" || $ext == "sh" || $ext == "png" ))
then

	#add the entered file to staging
	git add $name


	#Prompt user for commit message
	echo "please enter commit message"

	#Accept user input
	read message



	#commit the staged files
	git commit -m "$message"

	
	#Push the commit
	git push

else
	echo "that file will not be accepted"
fi
	