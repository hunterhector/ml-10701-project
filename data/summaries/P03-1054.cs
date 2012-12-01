Length ≤ 40 LP LR F1 Exact CB 0 CB Magerman (1995) 84.9 84.6 1.26 56.6 Collins (1996) 86.3 85.8 1.14 59.9 this paper 86.9 85.7 86.3 30.9 1.10 60.3 Charniak (1997) 87.4 87.5 1.00 62.1 Collins (1999) 88.7 88.6 0.90 67.1 Length ≤ 100 LP LR F1 Exact CB 0 CB this paper 86.3 85.1 85.7 28.8 1.31 57.2 Figure 8: Results of the final model on the test set (section 23).
P95-1037 P96-1025
Johnson (1998) showed that the performance of an unlexicalized PCFG over the Penn treebank could be improved enormously simply by annotating each node by its parent category.
J98-4004
Charniak (2000) shows the value his parser gains from parentannotation of nodes, suggesting that this information is at least partly complementary to information derivable from lexicalization, and Collins (1999) uses a range of linguistically motivated and carefully hand-engineered subcategorizations to break down wrong context-freedom assumptions of the naive Penn treebank covering PCFG, such as differentiating “base NPs” from noun phrases with phrasal modifiers, and distinguishing sentences with empty subjects from those where there is an overt subject NP.
A00-2018
In the following decade, great success in terms of parse disambiguation and even language modeling was achieved by various lexicalized PCFG models (Magerman, 1995; Charniak, 1997; Collins, 1999; Charniak, 2000; Charniak, 2001).
A00-2018 P01-1017 P95-1037
Specifically, we construct an unlexicalized PCFG which outperforms the lexicalized PCFGs of Magerman (1995) and Collins (1996) (though not more recent models, such as Charniak (1997) or Collins (1999)).
P95-1037 P96-1025
The raw treebank grammar corresponds to v = 1,h = ∞ (the upper right corner), while the parent annotation in (Johnson, 1998) corresponds to v = 2,h = ∞, and the second-order model in Collins (1999), is broadly a smoothed version of v = 2,h = 2.
J98-4004
One way of capturing this kind of external context is to use parent annotation, as presented in Johnson (1998).
J98-4004
12This is part of the explanation of why (Charniak, 2000) finds that early generation of head tags as in (Collins, 1999) is so beneficial.
A00-2018
For each model, input trees were annotated or transformed in some way, as in Johnson (1998).
J98-4004
constants. An unlexicalized PCFG parser is much simpler to build and optimize, including both standard code optimization techniques and the investigation of methods for search space pruning (Caraballo and Charniak, 1998; Charniak et al., 1998).
J98-2004 W98-1115
More recently, Gildea (2001) discusses how taking the bilexical probabilities out of a good current lexicalized PCFG parser hurts performance hardly at all: by at most 0.5% for test text from the same domain as the training data, and not at all for test text from a different domain.1 But it is precisely these bilexical dependencies that backed the intuition that lexicalized PCFGs should be very successful, for example in Hindle and Rooth’s demonstration from PP attachment.
W01-0521
O(n4) if using the clever approach of Eisner and Satta (1999).
P99-1059
In the raw grammar, there are many unaries, and once any major category is constructed over a span, most others become constructible as well using unary chains (see Klein and Manning (2001) for discussion).
P01-1044
This approach was congruent with the great success of word n-gram models in speech recognition, and drew strength from a broader interest in lexicalized grammars, as well as demonstrations that lexical dependencies were a key tool for resolving ambiguities such as PP attachments (Ford et al., 1982; Hindle and Rooth, 1993).
J93-1005
Magerman. 1995.
P95-1037
