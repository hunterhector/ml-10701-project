We have explained elsewhere (Clark, 2002) how suitable features can be defined in terms of the a18 word, pos-tag a20 pairs in the context, and how maximum entropy techniques can be used to estimate the probabilities, following Ratnaparkhi (1996).
W96-0213
the dependency probabilities The estimation method is based on Collins (1996).
P96-1025
Probability Model The DAG-like nature of the dependency structures makes it difficult to apply generative modelling techniques (Abney, 1997; Johnson et al., 1999), so we have defined a conditional model, similar to the model of Collins (1996) (see also the conditional model in Eisner (1996b)).
C96-1058 J97-4005 P96-1011 P96-1025 P99-1069
The treebank of derivations, which we call CCGbank (Hockenmaier and Steedman, 2002a), was in turn derived (semi-)automatically from the handannotated Penn Treebank.
P02-1043
While the model of Collins (1996) is technically unsound (Collins, 1999), our aim at this stage is to demonstrate that accurate, efficient wide-coverage parsing is possible with CCG, even with an over-simplified statistical model.
P96-1025
Collins (1999), Charniak (2000)).
A00-2018
Chiang (2000) uses Tree Adjoining Grammar as an alternative to context-free grammar, and here we use another “mildly context-sensitive” formalism, Combinatory Categorial Grammar (CCG, Steedman (2000)), which arguably provides the most linguistically satisfactory account of the dependencies inherent in coordinate constructions and extraction phenomena.
P00-1058
8A small number of sentences in the Penn Treebank do not appear in the CCGbank (see Hockenmaier and Steedman (2002a)).
P02-1043
Along with Hockenmaier and Steedman (2002b), this is the first CCG parsing work that we are aware of in which almost 98% of unseen sentences from the CCGbank can be parsed.
P02-1043
One solution is to consider only the normal-form (Eisner, 1996a) derivation, which is the route taken in Hockenmaier and Steedman (2002b).1 Another problem with the non-standard surface derivations is that the standard PARSEVAL performance measures over such derivations are uninformative (Clark and Hockenmaier, 2002).
C96-1058 P02-1043 P96-1011
(A similar argument is used by Collins (1996) in the context of his parsing model.) The estimate in equation 10 suffers from sparse data problems, and so a backing-off strategy is employed.
P96-1025
The training and testing material for this CCG parser is a treebank of dependency structures, which have been derived from a set of CCG derivations developed for use with another (normal-form) CCG parser (Hockenmaier and Steedman, 2002b).
P02-1043
First, in order to limit the number of categories assigned to each word in the sentence, a “supertagger” (Bangalore and Joshi, 1999) assigns to each word a small number of possible lexical categories.
J99-2004
Collins (1996), Collins (1999)), although our hypothesis was that it would be less useful here, because the CCG grammar provides many of the constraints given by ∆, and distance measures are biased against long-range dependencies.
P96-1025
