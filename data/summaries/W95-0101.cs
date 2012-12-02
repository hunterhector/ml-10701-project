This method is employed in \[Kupiec, 1992; Cutting et al., 1992\].
A92-1018
word tagger described in \[Brill, 1994\].
C94-2195
\[Brill, 1993a\] Brill, E.
P93-1035
2Some other approaches to tagging are described in \[Hindle, 1989; Black et al., 1992\].
H92-1023 P89-1015
Below is an example of the initial-state tagging of a sentence from the Penn Treebank \[Marcus et al., 1993\], where an underscore is to be read as or.
J93-2004
all cases, the combined training outperformed the purely supervised training at no added cost in terms of annotated 12The purely supervised learning algorithm is the same as that described in \[Brill, 1994\], except there the most likely tag for every word in the dictionary is provided to the learner.
C94-2195
Transformation-based error-driven learning has been applied to a number of natural language problems, including part of speech tagging, prepositional phrase attachment disambiguation, speech generation and syntactic parsing \[Brill, 1992; Brill, 1994; Ramshaw and Marcus, 1994; Roche and Schabes, 1995; Brill and Resnik, 1994; Huang et al., 1994; Brill, 1993a; Brill, 1993b\].
A92-1021 C94-2195 J93-2004 J95-2004 P93-1035 W94-0111
\[Linet al., 1994\] Lin, Y.
C94-1023
\[Weischedel et al., 1993; Charniak et al., 1993\]).
J93-2006
the learning algorithm is data-driven, it only needs to consider a small 3For a more detailed description of supervised transformation-based part of speech tagging, see \[Brill, 1994\].
C94-2195
\[Hindle, 1989\] Hindle, D.
P89-1015
\[Roche and Schabes, 1995\] Roche, E.
J95-2004
\[Brill, 1993b\] Brill, E.
P93-1035
Tagging with this finite state transducer requires n steps to tag a sequence of length n, independent of the number of rules, and results in a part of speech tagger ten times faster than the fastest stochastic tagger \[Roche and Schabes, 1995\].
J95-2004
In \[Brill, 1992; Brill, 1994\], a rule-based part of speech tagger is described which achieves highly competitive performance compared to stochastic taggers, and captures the learned knowledge in a set of simple deterministic rules instead of a large table of statistics.
A92-1021 C94-2195
\[Cutting et al., 1992\] Cutting, D.
A92-1018
This approach is described in \[Merialdo, 1995; Elworthy, 1994\].
A94-1009 J94-2001
\[Ramshaw and Marcus, 1994\] Ramshaw, L.
W94-0111
As mentioned above, in the supervised transformation-based tagger described in \[Brill, 1994\], each word is initially tagged with its most likely tag.
C94-2195
\[Church, 1988\] Church, K.
A88-1019
It was shown in \[Brill, 1994\] that the transformation-based tagger achieves a high rate of tagging accuracy.
C94-2195
The advantage of combining unsupervised and supervised learning over using supervised n\[Elworthy, 1994\] quotes accuracy on ambiguous words, which we have converted to overall accuracy.
A94-1009
\[Black et al., 1992\] Black, E.
H92-1023
\]\] \[Brill, 1992\] Brill, E.
A92-1021
\[Francis and Kucera, 1982; Marcus et al., 1993\]), training on a corpus of one type and then applying the tagger to a corpus of a different type usually results in a tagger with low accuracy \[Weischedel et al., 1993\].
J93-2004 J93-2006
\[Elworthy, 1994\] Elworthy, D.
A94-1009
When training a stochastic tagger using the Baum-Welch algorithm, overtraining often does occur \[Meriaido, 1995; Elworthy, 1994\], requiring an additional held-out training corpus for determining an appropriate number of training iterations.
A94-1009
4In \[Brill, 1994\], a total of 21 templates are used.
C94-2195
\[Brill, 1994\] Brill, E.
C94-2195
In \[Elworthy, 1994\], similar experiments were run.
A94-1009
Almost all of the work in the area of automatically trained taggers has explored Markov-model based part of speech tagging \[Jelinek, 1985; Church, 1988; Derose, 1988; DeMarcken, 1990; Cutting et al., 1992; Kupiec, 1992; Charniak et al., 1993; Weischedel et al., 1993; Schutze and Singer, 1994; Lin et al., 1994; Elworthy, 1994; Merialdo, 1995\].
A88-1019 A92-1018 A94-1009 C94-1023 J93-2006
In Proceedings of the Fifteenth International Conference on Computational Linguistics (COLING-1994), Kyoto, Japan.
C94-1023
Unsupervised Learning: Results To test the effectiveness of the above unsupervised learning algorithm, we ran a number of experiments using two different corpora and part of speech tag sets: the Penn Treebank Wall Street Journal Corpus \[Marcus et al., 1993\] and the original Brown Corpus \[Francis and Kucera, 1982\].
J93-2004
\[Marcus et al., 1993\] Marcus, M.
J93-2004
It is possible to use unsupervised learning to train stochastic taggers without the need for a manually annotated corpus by using the Baum-Welch algorithm \[Baum, 1972; Jelinek, 1985; Cutting et al., 1992; Kupiec, 1992; Elworthy, 1994; Merialdo, 1995\].
A92-1018 A94-1009
\[Brill and Resnik, 1994\] Brill, E.
C94-2195
\[Weischedel et al., 1993\] Weischedel, R.
J93-2006
