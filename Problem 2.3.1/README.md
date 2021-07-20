# Problem 2.3.1

## Section 1 
- Iterative cake cutting: The famous algorithm for fairly cutting a cake
  in two is for one person to cut the cake in the place that he believes
  is half and for the other person to choose which “half ” he likes
- One player may value the icing and while the other the cake more, 
  but it does not matter. The second player is guaranteed to get a
  piece that he considers to be worth at least a half, because he
  chooses between two pieces whose sum worth for him is at least 
  one. 
- Because the first person cut it in half according to his own criteria, 
  he is happy which ever piece is left for him. 
- Our goal is write an iterative algorithm that solves this same
problem for n players.
  
## Section 2
- To make our life easier, we view a cake not as three-dimensional thing, 
  but as the line from zero to one.
- Different players value different subintervals of the cake differently. 
- To express this, each player assigns some numerical value to each subinterval. 
- For example, if player pi’s name is written on the subinterval
  $ [{i−1 \over 2n }, { i \over 2n}]  $ of cake, then he might allocate a higher value to it, say $ 1 \over 2 $ .
- The only requirement is that the total value
of the cake is one.

## Section 3

- our algorithm is only allowed the following two operations.
  -  In an evaluation query, $v = Eval(p, [a,b]) $, the algorithm asks a player p how much (v) he values a particular subinterval [a,b] of the whole cake [0, 1].
  -  In a cut query, $ b = Cut(p,a, v) $, the protocol asks the player p to identify the shortest subinterval [a,b], starting at a given left endpoint a, with a given value v. 
  - In the above example, $ Eval(pi, [{ i−1 \over 2n} , {i \over 2n }]) $ returns 1/2 and $ Cut(pi, {i−1 \over 2n} ,{ 1 \over 2} )$ returns $ i \over 2n$ .
- Using these, the two-player algorithm is as follows:
  
![](Screenshot 2021-07-06 140916.png)