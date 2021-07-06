# Problem 1.5.1
- You are now the professor. Which of thesteps to develop an iterative algorithm did the student fail to do correctly in the following code? How? How would you fix it?

## The student algorithm

- algorithm Eg(I)
- (pre-cond): I is an integer.
- (post-cond): Outputs  $ s = \sum_{j=1}^{I} j  $
- begin
  - s = 0
  - i = 1
  - while( i ≤ I )
    - (loop-invariant) : Each iteration adds the next term giving that $s = \sum_{j=1}^{i} j  $
    - s = s +i
    - i = i + 1
  - end loop
- return(s)
- end algorithm


## Answer

- There are number of problems
  - the loop invarient must be a picture of the current state not say what the __loop does__ 
    - so the loop-invarient simply be $s = \sum_{j=1}^{i} j  $
- The loop invarient is not established correctly with i = 1, because of $ s = \sum_{j=1}^{1} j = 1$  not s = 0 .
  - so the choice of s = 0 ,  i = 0  would be better
- The loop invarient not maintained correctly, 
  - let s\` and i\` be the values of s and i when at the top of the loop
  - so s\`` and i\`` after going around again
  - so $ s' =\sum_{j=1}^{i'} j  $
  - The code gives that s'' = i' +s' and i'' = i' + 1
  - Together these give t