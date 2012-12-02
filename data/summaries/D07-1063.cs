The features used by Sassano (2004) are promising as well.
C04-1002
The comparison of the proposed method with Sassano (2004)’s method without the features of 1http://chasen.org/˜taku/software/ cabocha/ 2We have not tested the improvement statistically because we do not have access to the conventional methods.
C04-1002
Another notable method is Cascaded Chunking Model by Kudo and Matsumoto (2002).
W02-2016
Sassano (2004) parsed a sentence efficiently using a stack.
C04-1002
605 Table 4: Accuracy of dependency analysis on parallel structures Parallelstructures Otherthanparallelstructures PARENT 74.18% 91.21% ANCESTOR 73.24% 90.01% PARENT-ANCESTOR 76.29% 91.63% conjunctive structures (w/o Conj) and without the richer features derived from the words in chunks (w/o Rich) suggests that the proposed method is better than or comparable to Sassano (2004)’s method.
C04-1002
In this paper, we use the features proposed in Kudo and Matsumoto (2002).
W02-2016
We used the third degree polynomial kernel function and set the soft margin parameter C to 1, which is exactly the same setting as in Kudo and Matsumoto (2002).
W02-2016
For example, Haruno et al.(1999) used Decision Trees, Sekine (2000) used Maximum Entropy Models, Kudo and Matsumoto (2000) used Support Vector Machines.
C00-2110 W00-1303
The dataset is the same as in leading works (Sekine, 2000; Kudo and Matsumoto, 2000; Kudo and Matsumoto, 2002; Sassano, 2004).
C00-2110 C04-1002 W00-1303 W02-2016
The type C is not available in the proposed method because the proposed method analyzes a sentence backwards unlike Kudo and Matsumoto (2002).
W02-2016
Therefore, our methods analyze a sentence backwards as in Sekine (2000) and Kudo and Matsumoto (2000).
C00-2110 W00-1303
Table 3 shows that the proposed method outperforms conventional methods except Sassano (2004)2, while Sassano (2004) used richer features which are not used in the proposed method, such as features for conjunctive structures based on Kurohashi and Nagao (1994), features concerning the leftmost content word in the candidate modifiee.
C04-1002 J94-4001
PARENT METHOD differs from conventional methods such as Sekine (2000) or Kudo and Matsumoto (2000), in the process of determining the parent node.
C00-2110 W00-1303
Three types of dynamic features were used in Kudo and Matsumoto (2002): (A) the chunks modifying the current candidate modifiee, (B) the chunk modified by the current candidate modifiee, and (C) the chunks modifying the current candidate modifier.
W02-2016
We compare the proposed method particularly with Kudo and Matsumoto (2002) with the same feature set.
W02-2016
The reasons are that Cascaded Chunking Model proposed in Kudo and Matsumoto (2002) is used in a popular Japanese dependency analyzer, CaboCha 1, and the comparison can highlight the effectiveness of our approach because we can experiment under the same conditions (e.g., dataset, feature set, learning algorithm).
W02-2016
The features are the same as those used in Kudo and Matsumoto (2002).
W02-2016
Table 2 shows that PARENT-ANCESTOR METHOD is more accurate than the other two Table 2: Result of dependency analysis using methods described in Section 3 Method Dependency SentenceAccuracy Accuracy PARENT 88.95% 44.87% ANCESTOR 87.64% 43.74% PARENT-ANCESTOR 89.54% 47.38% Table 3: Comparison to conventional methods Feature Method Dependency SentenceAccuracy Accuracy Only Proposedmethod 88.88% 46.33%static KudoandMatsumoto(2002) 88.71% 45.19% Static+ Proposedmethod 89.43% 47.94%DynamicA,B KudoandMatsumoto(2002) 89.19% 46.64% Original Proposedmethod 89.54% 47.38%Sekine(2000) 87.20% 40.76% KudoandMatsumoto(2000) 89.09% 46.17%KudoandMatsumoto(2002) 89.29% 47.53% Sassano(2004) 89.56% 48.35%w/oRich Sassano(2004) 89.19% 47.05%w/oConj 89.41% 47.86% methods.
C00-2110 C04-1002 W00-1303 W02-2016
