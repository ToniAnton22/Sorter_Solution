# Sorter_Solution

The following task has been completed using a series of data-structures. Let's begin with the following:
![image](https://github.com/ToniAnton22/Sorter_Solution/assets/72076515/f7778e62-0968-40a8-a53b-341e59105559)

There are a few things to note:
- "alphabetNumbers"  is a dictionary that uses characters as "keys" and the number which these characters represent as "values". This way, it's easy for me to access the number representative of each letter.
- "sortedList" will be a sorted list of names
- "lettersInAlphabet" is meant to be appended later into the dictionary, as the computer needs a reference to add as keys
- "index" is redundant and will be removed later
- "names" is redundant and will be removed later
- the "for" function is used to append each number value to their letter. There are 26 letters in the alphabet so, starting from 0 and ending before 25, we get exactly 26 iteresations.
"alphabetNumbers.Add(lettersInAlphabet[i], i+1)" adds the key letter and it's value "i+1". the "i+1" is meant to prevent the value from being one less since our index starts at 0. An alternative would be to start the index at 1 and end it at 26, however
I choose the other approach as it doesn't really make a difference outside of visuals.


Inside the try catch, the program reads the file and creates an empty array  which will be filled with all the details within the file. "col=line.Split(',')" will read the file and split each member based on the "," character.

![image](https://github.com/ToniAnton22/Sorter_Solution/assets/72076515/955f5eca-c0bc-4680-be26-292e2f48b98f)

#function sortList
Takes 1 parameter, an array of strings.

![image](https://github.com/ToniAnton22/Sorter_Solution/assets/72076515/d11ea633-cede-4687-a1cf-87ab9f129630)

I then call the "sortList" function, append the array of names to the list, and then return the list sorted. This step might be a bit redundant, as I believe I can achieve the same thing outside of the function without having to reinvent the wheel.

# functio nameSum
Takes 2 parameters: a string "name" and a Dictionary containing a character as key and an integer as value.

![image](https://github.com/ToniAnton22/Sorter_Solution/assets/72076515/73cf1c41-47cb-4b84-af5c-4743242df040)


The computer will then go through the sorted list and send the "name" and "alphabetNumbers" dictionary to get the sum of the characters of each name, as well as take the sum and the name's position within the list to multiply them and complete our task.

The NameSum function takes the name and the "alphabetNumbers" dictionary, initializes an integer to store our sum, and then starts a loop the size of "name". I check for ' " ' this character as the double quotation mark seems to be stored in my sorted list, and can cause errors as they are not placed within the dictionary. This might be the cause of the string being stored as ' "name" ' or when reading the file, some of these quotation marks went wrong, however, I had to add this check for the integrity of the loop. If no character is '"' then it will add the value of the letter together until the loop is done and return our sum

# function getNameAndPostionSum
This takes 2 parameters: The position of the name within the sorted list, and the sum of characters.

![image](https://github.com/ToniAnton22/Sorter_Solution/assets/72076515/eed35835-d92e-4c98-92f0-4124d2ad3b66)

The function takes the position and adds "1" as our index starts at zero, but realistically, they do occupy 1 position, then multiply the result of the sum with the sum of characters, and return the product.


