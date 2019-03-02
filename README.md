# The Monty Hall Problem
- Read about it from here : https://en.wikipedia.org/wiki/Monty_Hall_problem
- Or watch numberphile videos :
  - for dummies : https://www.youtube.com/watch?v=7u6kFlWZOWg
  - for not-so-dummies : https://www.youtube.com/watch?v=4Lb-6rxZxx0
  - for hardcore-not-so-dummies : https://www.youtube.com/watch?v=ugbWqWCcxrg

# What this repo does:
this basically just creates random scenarios (10,000 tries), it chooses a random correct door, and a random picked door at first, then based on the approach you take (either switch or stay or random switch/stay), it checks if you picked the correct door or not.

# Explaination:
in general, this is basically a question of, what's the probability of choosing the same number twice from a set of numbers

if that probability is LOW, then you should go with SWITCHING, why? because if it's NOT the number i picked, then it's the other number.

if that probability is HIGH, then you should go with STAYING, why? because if it's the number i picked, then why change it?
```
lets say that we have 3 numbers a,b and c
these are all the possible combinations
N1          | a | a | a | b | b | b | c | c | c
N2          | a | b | c | a | b | c | a | b | c
Is Equal ?  | T | F | F | F | T | F | F | F | T

we have 3/9=1/3 chance to get it right, so we should go with switching
```
so if we have X numbers
the probability is X/X^2=1/X to get it right, so the more numbers you have, the less probable you get it right.
that's the theory people have debated over the years, so i created this repo to show its actual effectiveness in real scenarios.


# Results:
#### here are some results if you are too lazy to run the code yourself
 - Run 1
```
Testing 10,000 Tries
=========================================
============ Test Awalys Stay ===========
=========================================
Success for 3 doors: 3,346 (33.46% success rate)
Success for 10 doors: 1,012 (10.12% success rate)
Success for 100 doors: 83 (0.83% success rate)
Success for 10,000 doors: 0 (0% success rate)
=========================================
=========================================
=========== Test Awalys Switch ==========
=========================================
Success for 3 doors: 6,683 (66.83% success rate)
Success for 10 doors: 9,009 (90.09% success rate)
Success for 100 doors: 9,912 (99.12% success rate)
Success for 10,000 doors: 9,999 (99.99% success rate)
=========================================
=========================================
=============== Test Random =============
=========================================
Success for 3 doors: 4,958 (49.58% success rate)
Success for 10 doors: 5,066 (50.66% success rate)
Success for 100 doors: 5,079 (50.79% success rate)
Success for 10,000 doors: 5,107 (51.07% success rate)
=========================================
```
 - Run 2
```
Testing 10,000 Tries
=========================================
============ Test Awalys Stay ===========
=========================================
Success for 3 doors: 3,322 (33.22% success rate)
Success for 10 doors: 1,022 (10.22% success rate)
Success for 100 doors: 79 (0.79% success rate)
Success for 10,000 doors: 1 (0.01% success rate)
=========================================
=========================================
=========== Test Awalys Switch ==========
=========================================
Success for 3 doors: 6,750 (67.5% success rate)
Success for 10 doors: 8,983 (89.83% success rate)
Success for 100 doors: 9,893 (98.93% success rate)
Success for 10,000 doors: 9,999 (99.99% success rate)
=========================================
=========================================
=============== Test Random =============
=========================================
Success for 3 doors: 4,968 (49.68% success rate)
Success for 10 doors: 5,060 (50.6% success rate)
Success for 100 doors: 4,961 (49.61% success rate)
Success for 10,000 doors: 5,040 (50.4% success rate)
=========================================
```
 - Run 3
```
Testing 10,000 Tries
=========================================
============ Test Awalys Stay ===========
=========================================
Success for 3 doors: 3,308 (33.08% success rate)
Success for 10 doors: 956 (9.56% success rate)
Success for 100 doors: 110 (1.1% success rate)
Success for 10,000 doors: 0 (0% success rate)
=========================================
=========================================
=========== Test Awalys Switch ==========
=========================================
Success for 3 doors: 6,690 (66.9% success rate)
Success for 10 doors: 8,982 (89.82% success rate)
Success for 100 doors: 9,875 (98.75% success rate)
Success for 10,000 doors: 9,997 (99.97% success rate)
=========================================
=========================================
=============== Test Random =============
=========================================
Success for 3 doors: 5,017 (50.17% success rate)
Success for 10 doors: 5,080 (50.8% success rate)
Success for 100 doors: 5,047 (50.47% success rate)
Success for 10,000 doors: 5,000 (50% success rate)
=========================================
```
# Conclusion:
it becomes more apparent that the more numbers you have, the less probable you get the correct number,
# ***So in general, switching is the most logical approach to take***