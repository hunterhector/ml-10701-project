(Our goal is to replicate the supervision of a treebank, but not a semantic dictionary, so we do not compare against (Stetina and Nagao, 1997)).
W97-0109
Recently, (Stetina and Nagao, 1997) have reported 88% accuracy by using a corpus-based model in conjunction with a semantic dictionary.
W97-0109
This technique is similar to the one in (Hindle and Rooth, 1993), and interpolates between the tendencies of the (v,p) and (n,p) bigrams and the tendency of the type of attachment (e.g., N or V) towards a particular preposition p.
J93-1005
Table 4 shows accuracies of the classifiers on the test set of (Ratnaparkhi et al., 1994), which is derived from the manually annotated attachments in the Penn Treebank Wall St.
H94-1048
Our procedure differs critically from (Hindle and Rooth, 1993) in that we do not iterate, we extract unambiguous attachments from unparsed input sentences, and we totally ignore the ambiguous cases.
J93-1005
Later work, such as (Ratnaparkhi et al., 1994; Brill and Resnik, 1994; Collins and Brooks, 1995; Merlo et al., 1997; Zavrel and Daelemans, 1997; Franz, 1997), trains and tests on quintuples of the form (v,n,p, n2,a) extracted from the Penn treebank(Marcus et al., 1994), and has gradually improved on this accuracy with other kinds of statistical learning methods, yielding up to 84.5% accuracy(Collins and Brooks, 1995).
C94-2195 H94-1048 P97-1024 P97-1056 W95-0103 W97-0317
(Hindle and Rooth, 1993) describes a partially supervised approach in which the FIDDITCH partial parser was used to extract (v,n,p) tuples from raw text, where p is a preposition whose attachment is ambiguous between the head verb v and the head noun n.
J93-1005
The tagger from (Ratnaparkhi, 1996) first annotates sentences of raw text with a sequence of partof-speech tags.
W96-0213
This extraction heuristic loosely resembles a step in the bootstrapping procedure used to get training data for the classifier of (Hindle and Rooth, 1993).
J93-1005
