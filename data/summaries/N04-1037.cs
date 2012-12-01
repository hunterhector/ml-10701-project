Maximum Entropy Modeling As previously indicated, the weight-based scheme of L&L suggests MaxEnt modeling (Berger et al., 1996) as a particularly natural choice for a machine learning approach.
J96-1002
To address the data-sparsity issue, we employed the technique used in Keller and Lapata (2003, K&L) to get a more robust approximation of predicate-argument counts.9 We wrote 7These performance results include 64 “impossible” cases in which, due to misparsing, no correct antecedents were provided to the model; hence 91.6% accuracy is the best that could be achieved.
J03-3005
Examples include the number of sentences between them and the “Hobbs distance”, that is, the number of noun groups that Hobbs’s search algorithm has to skip before the potential antecedent is found (Hobbs, 1978; Ge et al., 1998).
W98-1119
Second, wetried an approachbased on the distributional clustering method of Pereira et al.(1993). This method yielded word classes that offered more robust count approximations for their member words.
P93-1024
Our point of departure is the work of Lappin and Leass (1994, henceforth L&L) and Dagan et al.(1995). (See also Dagan and Itai (1990)).
C90-3063 J94-4002
L&L demonstrated with a system called RAP that a (manually-tuned) weight-based scheme for integrating pronoun interpretation preferences can achieve high performance on real data, in their case, 86% accuracy on a corpus of computer training manuals.1 Dagan et al.(1995) then developed a postprocessor based on predicate-argument statistics that was used to override RAP’s decision when it failed to express a clear preference between two or more antecedents, which resulted in a modest rise in per1Kennedy and Boguraev (1996, henceforth, K&B) adapted L&L’s algorithm to rely on far less syntactic analysis (noun phrase identification and rudimentary grammatical role marking), with performance in the 75% range on mixed genres.
C96-1021
