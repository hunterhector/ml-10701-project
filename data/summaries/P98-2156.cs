Section 5 first explains why the algorithm from Schabes and Vijay-Shanker (1990) is incorrect, and then provides an example of how our new algorithm works.
P90-1035
example For the TAG presented in Figure 1, the algorithm from Schabes and Vijay-Shanker (1990) does not work correctly.
P90-1035
We therefore developed an alternative to the algorithm from Schabes and Vijay-Shanker (1990).
P90-1035
A first attempt to adapt LR parsing to treeadjoining grammars (TAGs) was made by Schabes and Vijay-Shanker (1990).
P90-1035
The language described by the grammar contains exactly the strings abc, a'b'c ~, adbec, and a'db'ecq The algorithm from Schabes and Vijay-Shanker (1990) however also accepts adb'ec' and a~dbec.
P90-1035
