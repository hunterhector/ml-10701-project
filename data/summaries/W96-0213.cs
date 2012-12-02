ARPA. \[Magerman, 1995\] David M.
P95-1037
\[Ratnaparkhi et al., 1994\] Adwait Ratnaparkhi, Jeff Reynar, and Salim Roukos.
H94-1048
\[Brown et al., 1992\] Peter F Brown, Vincent DellaPietra, Peter V deSouza, Jennifer C Lai, and Robert L Mercer.
J92-4003
Journal data, 96.5%(Magerman, 1995), is similar to that presented in this paper.
P95-1037
\[Merialdo, 1994\] Bernard Merialdo.
J94-2001
Several recent papers(Brill, 1994, Magerman, 1995) have reported 96.5% tagging accuracy on the Wall St.
P95-1037
\[Berger et al., 1996\] Adam Berger, Stephen A.
J96-1002
Previous uses of this model include language modeling(Lau et al., 1993), machine translation(Berger et al., 1996), prepositional phrase attachment(Ratnaparkhi et al., 1994), and word morphology(Della Pietra et al., 1995).
H93-1021 H94-1048 J96-1002
In practice, 7-/ is very large and the model's expectation Efj cannot be computed directly, so the following approximation(Lau et al., 1993) is used: n E fj,~ E15(hi)p(tilhi)fj(hi,ti) i=1 where fi(hi) is the observed probability of the history hi in the training set.
H93-1021
MaxEnt can provide a probability for each tagging decision, which can be used in the probability calculation of any structure that is predicted over the POS tags, such as noun phrases, or entire parse trees, as in (Jelinek et al., 1994, Magerman, 1995).
H94-1052 P95-1037
\[Weischedel et al., 1993\] Ralph Weischedel, Marie Meteer, Richard Schwartz, Lance Ramshaw, and Jeff Palmucci.
J93-2006
140 A POS tagger is one component in the SDT based statisticM parsing system described in (Jelinek et al., 1994, Magerman, 1995).
H94-1052 P95-1037
However, the aforementioned SDT techniques require word classes(Brown et al., 1992) to help prevent data fragmentation, and a sophisticated smoothing algorithm to mitigate the effects of any fragmentation that occurs.
J92-4003
\[Jelinek et al., 1994\] F Jelinek, J Lafferty, D Magerman, R Mercer, A Ratnaparkhi, and S Roukos.
H94-1052
Comparison With Previous Work Most of the recent corpus-based POS taggers in the literature are either statistically based, and use Markov Model(Weischedel et al., 1993, Merialdo, 1994) or Statistical Decision Tree(Jelinek et al., 1994, Magerman, 1995)(SDT) techniques, or are primarily rule based, such as Drill's Transformation Based Learner(Drill, 1994)(TBL).
H94-1052 J93-2006 J94-2001 P95-1037
Magerman. 1995.
P95-1037
Annotator (Weischedel et al., 1993) provide the results from a battery of "tri-tag" Markov Model experiments, in which the probability P(W,T) of observing a word sequence W = {wl,w2,...,wn} together with a tag sequence T = {tl,t2,...,tn} is given by: P(TIW)P(W) p(tl)p(t21tl) × H P(tilti-lti-2) p(wilti i=3 Furthermore, p(wilti) for unknown words is computed by the following heuristic, which uses a set of 35 pre-determined endings: p(wilti) p(unknownwordlti ) x p(capitalfeature\[ti) x p(endings, hypenationlti ) This approximation works as well as the MaxEnt model, giving 85% unknown word accuracy(Weischedel et al., 1993) on the Wall St.
J93-2006
\[Lau et al., 1993\] Ray Lau, Ronald Rosenfeld, and Salim Roukos.
H93-1021
