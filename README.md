# Sorter_Solution

The following task has been completed using a series of data-structures. Lets begin with the following:
![image](https://github.com/ToniAnton22/Sorter_Solution/assets/72076515/f7778e62-0968-40a8-a53b-341e59105559)

There are a few things to note:
- "alphabetNumbers"  is a dictionary which uses characters as "keys" and the number which these characters represent as "values". This way, it's easy for me to access the number representative of each letter.
- "sortedList" will be a sorted list of names
- "lettersInAlphabet" is meant to be appended later into the dictionary, as the computer needs a reference to add as keys
- "index" is redundent and will be removed later
- "names" is redundent and will be removed later
- the "for" function is used to append each number value to their letter. There are 26 letters in the alphabet so, starting from 0 and ending before 25, we get exactly 26 iteresations.
"alphabetNumbers.Add(lettersInAlphabet[i], i+1)" adds the key letter and the it's value "i+1". the "i+1" is meant to prevent the value to be one less, since our index starts at 0. An alternative would be to start the index at 1 and end it at 26, however
I choose the other approach as it doesn't really make a difference outside of visuals.



