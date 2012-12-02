One possible direction here is to exploit the relatively rich linguistic representation of the input sentences (POS tags, lemmas and dependency structures), for instance, along the lines of [Bangalore and Rambow, 2000].
C00-1007
[Barzilay et al., 1999] R.
P99-1071
alignment In this section, we describe the alignment algorithm that we use (section 3.1), and evaluate its performance (section 3.2). 3.1 Tree alignment algorithm The tree alignment algorithm is based on [Meyers et al., 1996], and similar to that used in [Barzilay, 2003].
C96-1078
[Meyers et al., 1996] A.
C96-1078
[Carletta, 1996] Jean Carletta.
J96-2004
[Lapata, 2003] M.
P03-1069
The table also shows the κ-score, which is another commonly used measure for inter-annotator agreement [Carletta, 1996].
J96-2004
Initially work focused on word-based alignment, but more recent research also addresses alignment at the higher levels (substrings, syntactic phrases or trees), e.g.,[Gildea, 2003].
P03-1011
Starting point was the sentence fusion model proposed by [Barzilay et al., 1999; Barzilay, 2003] in which dependency analyses of pairs of sentences are first aligned, after which the aligned parts (representing the common information) are fused.
P99-1071
References [Bangalore and Rambow, 2000] Srinivas Bangalore and Owen Rambow.
C00-1007
[Pang et al., 2003] Bo Pang, Kevin Knight, and Daniel Marcu.
N03-1024
The alignment algorithm is tested with the following NODEMATCH function: NODEMATCH(v,vprime) = 8> >>> >< >>>> >: 10 if STR(v) = STR(vprime) 5 if LABEL(v) = LABEL(vprime) 2 if LABEL(v) is a synonym hyperonym or hyponym of LABEL(vprime) 0 otherwise 1In the original formulation of the algorithm by [Meyers et al., 1996], there is a penalty for skipping edges.
C96-1078
Similar work is described in [Pang et al., 2003], who describe a syntax-based algorithm that builds word lattices from parallel translations which can be used to generate new paraphrases.
N03-1024
In this paper, we take a closer look at sentence fusion [Barzilay, 2003][Barzilay et al., 1999], one of the interesting variants in text-to-text generation.
P99-1071
[Gildea, 2003] D.
P03-1011
Such applications are sometimes referred to as text-to-text generation applications (e.g., [Chandrasekar and Bangalore, 1997], [Knight and Marcu, 2002], [Lapata, 2003]), and may be likened to earlier revision-based generation strategies, e.g.
P03-1069
