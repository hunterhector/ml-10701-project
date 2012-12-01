For all factors except CNTX-S and POSS-S, we adopt the values derived from a series of experiments described in (Lappin and Leass, 1994) which used different settings to determine the relative importance of 1The implementation of a COREF object needs to be aware of potenlial circularities, thus a COREF does not actually contain its member discourse referents, but rather a listing of their offsets, each factor as a function of the overall success of the algorithm.
J94-4002
Second, and most importantly, the absence of explicit configurational information does not result in a substantial degradation in the accuracy of an anaphora resolution algorithm that is otherwise similar to that described in (Lappin and Leass, 1994).
J94-4002
This is a point of difference between our algorithm and the one described in (Lappin and Leass, 1994).
J94-4002
In this paper, we present work on modifying the lmppin/Leass algorithm in a way which enables it to work off a flat morpho-syntactic analysis of the sentences of a text, while retaining a degree of quality and accuracy in pronorainal anaphora resolution comparable to that reported in (Lappin and l,eass, 1994).
J94-4002
Following (Lappin and Leass, 1994), we will refer to these constraints as "salience factors".
J94-4002
(Lappin and Leass, 1994) use configurational information in two ways: as a factor in the determination of the salience of a discourse referent (discussed below), and as input to a set of disjoint reference filters.
J94-4002
Our salience factors mirror those used by (Lappin and Leass, 1994), with the exception of Poss-s, discussed below, and CNTX-S, which is sensitive to the context in which a discourse referent appears, where a context is a topically coherent segment of text, as determined by a text-segmentation algorithm which follows (Hearst, 1994).
J94-4002 P94-1002
SENT-S: 100 iff in the current sentence CNTX-S: 50 iff in the current context SUBJ-S: 80 iff GFUN = subject EXST-S: 70 iff in an existential construction POSS-S: 65 iff GFUN = possessive ACC-S: 50 iff GFUN = direct object DAT-S: 40 iff GFUN = indirect object OBLQ-S: 30 iff the complement of a preposition HEAD-S: 80 iff EMBED = NIL ARG-S: 50 iff ADJUNCT = NIL Note that the values of salience factors are arbitrary; what is crucial, as pointed out by (Lappin and Leass, 1994), is the relational structure imposed on the factors by these values.
J94-4002
