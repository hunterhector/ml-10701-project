We use FrameNet (Baker et al., 1998), a semantic lexicon for English that groups words in semantic classes called frames and lists semantic roles for each frame.
P98-1013
Some approaches have used WordNet for the generalization step (Resnik, 1996; Clark and Weir, 2001; Abe and Li, 1993), others EM-based clustering (Rooth et al., 1999).
N01-1013 P99-1014
We will be using the similarity metrics shown in Table 1: Cosine, the Dice and Jaccard coefficients, and Hindle’s (1990) and Lin’s (1998) mutual information-based metrics.
P90-1034 P98-2127
While EM-based models have been shown to work better in SRL tasks (Gildea and Jurafsky, 2002), this has been attributed to the difference in coverage.
J02-3001
The argument positions for which we compute selectional preferences will be semantic roles in the FrameNet (Baker et al., 1998) paradigm, and the predicates we consider will be semantic classes of words rather than individual words (which means that different preferences will be learned for different senses of a predicate word).
P98-1013
They have been used for example for syntactic disambiguation (Hindle and Rooth, 1993), word sense disambiguation (WSD) (McCarthy and Carroll, 2003) and semantic role labeling (SRL) (Gildea and Jurafsky, 2002).
J02-3001 J03-4004 J93-1005
Brockmann and Lapata (2003) perform a comparison of WordNet-based models.
E03-1034
To determine headwords of the semantic roles, the corpus was parsed using the Collins (1997) parser.
P97-1003
Rooth et al.(1999) generalize over seen headwords using EM-based clustering rather than WordNet.
P99-1014
The preference that rp has for a given synset c0, the selectional association between the two, is then defined as the contribution of c0 to rp’s selectional preference strength: A(rp,c0) = P(c0|rp)log P(c0|rp)P(c0) S(rp) Further WordNet-based approaches to selectional preference induction include Clark and Weir (2001), and Abe and Li (1993).
N01-1013
It was parsed using Minipar (Lin, 1993), which is considerably faster than the Collins parser but failed to parse about a third of all sentences.
P93-1016
While there have been no isolated comparisons of the two generalization paradigms that we are aware of, Gildea and Jurafsky’s (2002) task-based evaluation has found clusteringbased approaches to have better coverage than WordNet generalization, that is, for a given role there are more words for which they can state a preference.
J02-3001
In this paper we propose a new, simple model for selectional preference induction that uses corpus-based semantic similarity metrics, such as Cosine or Lin’s (1998) mutual informationbased metric, for the generalization step.
P98-2127
In SRL, the two most pressing issues today are (1) the development of strong semantic features to complement the current mostly syntacticallybased systems, and (2) the problem of the domaindependence (Carreras andMarquez, 2005).
W05-0620
Experimental design Like Rooth et al.(1999) we evaluate selectional preference induction approaches in a pseudodisambiguation task.
P99-1014
