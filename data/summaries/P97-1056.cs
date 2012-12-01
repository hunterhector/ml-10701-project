More recently, the integration of information sources, and the modeling of more complex language processing tasks in the statistical framework has increased the interest in smoothing methods (Collins ~z Brooks, 1995; Ratnaparkhi, 1996; Magerman, 1994; Ng & Lee, 1996; Collins, 1996).
H94-1048 P96-1006 P96-1025 W95-0103 W96-0213
Collins & Brooks' (1995) Back-off model is more sophisticated than the naive model, because they performed a number of validation experiments on heldout data to determine which terms to include and, more importantly, which to exclude from the backoff sequence.
W95-0103
An alternative method to determine the interpolation weights without iterative training on held-out data is given in Samuelsson (1996).
C96-2151
But if we do have some information about feature relevance one possibility would be to add linguistic bias to weight or select different features (Cardie, 1996).
W96-0211
There are two main approaches to smoothing: count re-estimation smoothing such as the Add-One or Good-Turing methods (Church & Gale, 1991), and Back-off type methods (Bahl et al., 1983; Katz, 1987; Chen & Goodman, 1996; Samuelsson, 1996).
C96-2151 P96-1041
We used a data-set extracted from the Penn Treebank WSJ corpus by Ratnaparkhi et al.(1994). It consists of sentences containing the possibly ambiguous sequence verb noun-phrase PP.
H94-1048
It is our experience that even limited forms of abstraction can harm performance on linguistic tasks, which often contain many subregularities and exceptions (Daelemans, 1996).
W96-0102
An exception is the use of similarity for alleviating the sparse data problem in language modeling (Essen & Steinbiss, 1992; Brown et al., 1992; Dagan et al., 1994).
J92-4003 P94-1038
The data-set contains 20801 training cases and 3097 separate test cases, and was also used in Collins & Brooks (1995).
W95-0103
Collins. 1996.
P96-1025
There is a large number of potentially informative features that could play a role in correctly predicting the tag of an unknown word (Ratnaparkhi, 1996; Weischedel et al., 1993; Daelemans et al., 1996).
J93-2006 W96-0102 W96-0213
If we isolate the pure back-off function of the interpolation equation we get an algorithm similar to the one used in Collins & Brooks (1995).
W95-0103
We will focus here on a comparison with Back-off type methods, because an experimental comparison in Chen & Goodman (1996) shows the superiority of Back-off based methods over count re-estimation smoothing methods.
P96-1041
