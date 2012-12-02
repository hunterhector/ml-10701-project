Some recent models permit discontiguous phrases (Chiang, 2007; Quirk et al., 2005; Simard et al., 2005).
H05-1098 P05-1034
This corpus is roughly the same as the one used for large-scale experiments by Chiang et al.(2005). To generate alignments, we used GIZA++ (Och and Ney, 2003).
H05-1098 J03-1002
We symmetrized bidirectional alignments using the growdiag-final heuristic (Koehn et al., 2003).
N03-1017
1 Callison-Burch et al.(2005) and Zhang and Vogel (2005) use suffix arrays as follows.
P05-1032
Requirements As shown in Callison-Burch et al.(2005), we must keep an array for the source text F, its suffix array, the target text E, and alignment A in memory.
P05-1032
Zens and Ney (2007) use a disk-based prefix tree, enabling efficient access to phrase tables much too large to fit in main memory.
N07-1062
However,inmachinetranslationmostfeatures can still be traced back to the IBM Models of 15 years ago (Lopez, 2007b).
D07-1104
However, recent work by Och (2005) and Federico and Bertoldi (2006) has shown that the statistics used by phrase-based systems are not very precise.
W06-3113
3. For each instance of ¯f found in F, find its aligned phrase ¯e using the phrase extraction method of Koehn et al.(2003). 4.
N03-1017
Due to space constraints, details and proof of correctness are available in Lopez (2007a).
D07-1104
This model would bring statistical machine translation closer to convergence with so-called example-based translation, following current trends (Marcu, 2001; Och, 2002).
P01-1050
a pattern is successfully found, we add all patterns with m + 1 terminals that are prefixed by it 9Conveniently, the implementation of Chiang (2007) uses a prefix tree grammar encoding, as described in Klein and Manning (2001).
P01-1044
Both Callison-Burch et al.(2005) and Zhang and Vogel (2005) solve this with sampling.
P05-1032
We tackle the problem using the online rule extraction method of Callison-Burch et al.(2005) and Zhang and Vogel (2005).
P05-1032
However, justasZensandNey(2007)doforphrasetables, wecouldcompileourdatastructuresintobinarymemory-mappedfiles,which can be read into memory in a matter of seconds.
N07-1062
Both Callison-Burch et al.(2005) and Zhang and Vogel (2005) use suffix arrays to relax the length constraints on phrase-based models.
P05-1032
An alternative approach introduced independently by both Callison-Burch et al.(2005) and Zhang and Vogel (2005) is to store the training data itself in memory, and use a suffix array as an efficient index to look up, extract, and score phrase pairs on the fly.
P05-1032
So far, these techniques have focused on phrasebased models using contiguous phrases (Koehn et al., 2003; Och and Ney, 2004).
J04-4002 N03-1017
