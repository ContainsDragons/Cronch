# Contributing

## Guidelines
### If you want to contribute, please follow these rules

1: The bracket format looks like this: 
```cs
if (this)
{
  Stuff();
}
```
 2: Please comment all your code and what it does. 
 
 3: Sign your name at the end of all comments.
 ```cs
 //This is a variable that has a value. (Your Name Here)
 ```
 
 4: Make sure everything is tested and up to date
 
 5: The `else/elseif` format looks like this:
 ```cs
if (this)
{
  Stuff();
}
else
{
  this = false
}
```

5: Make sure there is some spacing making it easier to read

6: Camel spelling for variables and start classes and functions with a capital
```cs
private void Stuff()
{
	 this = true
}
```
```cs 
private int thisIsCamelSpelling = 0;
```

7: If bools are in an `if` statement either use `!boolName` or `boolName` instead of `boolName = true`
```cs
if (boolName = true) //No thanks

if (boolName) //yes

if (!boolName) //yes
```

8: If you are not sure how to format, look at my code :)

9: Have fun!
