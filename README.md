# Name sorter

Written in C# 
**by Thomas Doig** (Glowing Moth) 3d Artist & Software Developer <br>
[Portfolio - Needs updating ](https://thomasdoig.netlify.app/) <br>
[Artstation - Some of my 3d work](https://www.artstation.com/thomasdoig)

## Background
At the time of writing this program I have had no recent experience in C# and have been heavily involved with Python and Django. For this reason several things stated within the assessment criteria have been skipped.

## Overview:
This is a coding assessment to sort a list of names by surname.
A list of unsorted names in a .txt file will be written to the application directory.

## My Original Plan / Thoughts 
I thought the best approach would have been to use one of the built-in sorting methods for Lists like .Sort() and to just sort based on the index rather than it's default. So this would mean iterating through the names at the last names first letter of the surname index and middle name index and the Sort() would have taken care of the rest. Unfortunately my lack of experience with C# prevented me from using this approach.

# Instructions:
1. Clone the remote repo and navigate to it.
2. Locate the "Application" directory within cloned name-sorter
3. Within the "Application" you will find the Name-Sorter.exe and a file called **"unsorted-names-list.txt"**
4. Double click the Name-Sorter.exe to generate a sorted list called "sorted-names-list.txt" in the Application directory.
5. Your unsorted file **MUST BE NAMED** **"unsorted-names-list.txt"**

## Known issues / Future Updates:
- This is program uses a simple bubble sorting algorithm. 
- The sort currently only sorts by the first letter of each surname.
- Each name should be on a new line
- The code is obviously not DRY and there is no guard clause / error handling
- Only sorts based on the (1st) letter of the surname instead of sorting by every letter.
- No sort is performed on middle name.





