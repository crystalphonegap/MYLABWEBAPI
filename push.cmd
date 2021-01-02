@ECHO OFF

:: This CMD script provides you with your operating system, hardware and network information.

TITLE *****CREATED BY AHMED SHAIKH*****

ECHO Adding File please wait... 

git add .
echo "Enter your changes info: " 
 
read commit   

echo "Your changes info is as  $commit "  
 
git commit -m commit

ECHO Commiting please wait... 

git push
ECHO Push Done
