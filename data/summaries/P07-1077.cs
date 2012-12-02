We should therefore aim at formal means capable of describing all non-projective structures that are both expressive and fine-grained enough to be useful in statistical approaches, and at the same time suitable for an adequate linguistic description.2 Holan et al.(1998) first defined an infinite hierarchy of classes of dependency trees, going from projective to unrestricted dependency trees, based on the notion of gap degree for subtrees (cf.
W98-0503
This supports our theoretical results and confirms that properties of non-projective edges provide a more accurate as well as expressive means for describing nonprojective structures in natural language than the constraints and measures considered by Kuhlmann and Nivre (2006).
E06-1010 P06-2066
On the other hand, Holan et al.(1998; 2000) show that at least for Czech neither of these two measures can in principle be bounded.
W98-0503
None of the constraints and measures in Kuhlmann and Nivre (2006) take into account levels of nodes explicitly.
E06-1010 P06-2066
This measure corresponds to the tree-based gap degree measure in (Kuhlmann and Nivre, 2006), which was first introduced in (Holan et al., 1998)— there it is defined as the maximum over gap degrees of all subtrees of a dependency tree (the gap degree of a subtree is the number of contiguous intervals in the gap of the subtree).
E06-1010 P06-2066 W98-0503
In this paper, we consider all constraints and measures evaluated by Kuhlmann and Nivre (2006)— with some minor variations, cf.
E06-1010 P06-2066
This measure was introduced by Nivre (2006); Kuhlmann and Nivre (2006) call it edge degree.
E06-1010 P06-2066
Theinterestedreadercanfindamorein-depthand broader-coverage discussion of properties of dependency trees and their application to natural language syntax in (Havelka, 2007a).
N07-2016
The following result is a direct extension of the results presented in Havelka (2005; 2007b).
N07-2016
Dependency analysis of natural language has been gaining an ever increasing interest thanks to its applicability in many tasks of NLP—a recent example is the dependency parsing work of McDonald et al.(2005), which introduces an approach based on the search for maximum spanning trees, capable of handling non-projective structures naturally.
H05-1066
The study of dependency structures occurring in natural language can be approached from two sides: by trying to delimit permissible dependency structures through formal constraints (for a recent review paper, see Kuhlmann and Nivre (2006)), or by providing their linguistic description (see e.g.
E06-1010 P06-2066
Well-nestedness was proposed by Bodirsky et al.(2005). The original formulation forbids interleaving of disjoint subtrees in the total order on nodes; we present an equivalent formulation in terms of non-projective edges, derived in (Havelka, 2007b).
N07-2016
Properties of level types are presented in Havelka (2005; 2007b).6 We propose a new measure combining level types and component degrees.
N07-2016
and experimental setup We evaluate all constraints and measures described in the previous section on 12 languages, whose treebanks were made available in the CoNLL-X shared Figure 3: Sample non-projective tree considered planar in empirical evaluation task on dependency parsing (Buchholz and Marsi, 2006).
W06-2920
The notion of gap is defined differently for subtrees of a dependency tree (Holan et al., 1998; Bodirsky et al., 2005).
W98-0503
We derive a formal property of these signatures that links them to the constraint of well-nestedness, which is an extension of the result for level types (see also Havelka (2007b)).
N07-2016
They confirm the findings of Kuhlmann and Nivre (2006): planarity seems to be almost as restrictive as projectivity; well-nestedness, on the other hand, covers large proportions of trees in all languages.
E06-1010 P06-2066
