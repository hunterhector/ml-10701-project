1°Our formalization of the evidence of decision list learning has an advantage over the decision tree learning (Quinlan, 1993) approach to feature selection of dependency analysis (Haruno et al., 1998).
P98-1083
15Fujio and Matsumoto (1998)'s lexicalized dependency analyzer is similar to that of Collins (1996), where various features were evaluated through performance test and an optimal feature set was manually selected.
P96-1025
Then, as a statistical learning method, we employ the decision list learning method of Yarowsky (1994), where optimal combination of those features are selected and sorted in the form of decision rules, according to the strength of correlation between those features and the dependency preference of the two subordinate clauses.
P94-1013
Next, we compare our model with the other two models: (a) the model learned by applying the decision tree learning method of Haruno et al.(1998) to our task of deciding dependency between two subordinate clauses, and (b) a decision list whose decisions are the following two cases, i.e., the case where dependency relation holds between the given two vp chunks or clauses, and the case where dependency relation does not hold.
P98-1083
As a statistical learning method, we employ the decision list learning method of Yarowsky (1994).
P94-1013
Roughly speaking, the first corresponds to the case where Clause2 inherently has a scope of the same or a broader breadth compared with that of Clause1, while the second corresponds to the case where Clause2 inherently has a narrower scope compared with that of Clause1.7 3.2 Decision List Learning A decision list (Yarowsky, 1994) is a sorted list of the decision rules each of which decides the value of a decision D given some evidence E.
P94-1013
The model (b) corresponds to a model in which standard approaches to statistical dependency analysis (Collins, 1996; Fujio and Matsumoto, 1998; Haruno et al., 1998) are applied to our task of deciding dependency between two subordinate clauses.
P96-1025 P98-1083
Each decision rule in a decision list is sorted TOur modeling is slightly different from those of other standard approaches to statistical dependency analysis (Collins, 1996; Fujio and Matsumoto, 1998; Haruno et al., 1998) which simply distinguish the two cases: the case where dependency relation holds between the given two vp chunks or clauses, and the case where dependency relation does not hold.
P96-1025 P98-1083
~Previous works on statistical dependency analysis include Fujio and Matsumoto (1998) and Haruno et al.(1998) in Japanese analysis as well as Lafferty et al.(1992), Eisner (1996), and Collins (1996) in English analysis.
C96-1058 P96-1025 P98-1083
