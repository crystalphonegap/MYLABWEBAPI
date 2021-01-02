@ECHO OFF

:: This CMD script provides you with your operating system, hardware and network information.

TITLE *****CREATED BY AHMED SHAIKH*****

ECHO Adding File please wait... 
echo
git add .
echo "Enter your changes info: " 
echo 
read commit   
echo
echo "Your changes info is as  $commit "  
echo  
git commit -m commit
echo
ECHO Commiting please wait... 
echo
git push
ECHO Push Done
