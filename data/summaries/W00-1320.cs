This includes both the parsers that attach probabilities to parser moves (Magerman, 1995; Ratnaparkhi, 1997), but also those of the lexicalized PCFG variety (Collins, 1997; Charniak, 1997).
P95-1037 P97-1003 W97-0301
Most recently, in (Stetina et al., 1998), the authors made use of head-driven bilexical dependencies with syntactic relations to attack the problem of generalized word-sense disambiguation, precisely one of the two problems we are dealing with here.
W98-0701
from previous work 2.2.1 Parsing In recent years, the success of statistical parsing techniques can be attributed to several factors, such as the increasing size of computing machinery to accommodate larger models, the availability of resources such as the Penn Treebank (Marcus et al., 1993) and the success of machine learning techniques for lowerlevel NLP problems, such as part-of-speech tagging (Church, 1988; Brill, 1995), and PPattachment (Brill and Resnik, 1994; Collins and Brooks, 1995).
A88-1019 C94-2195 J93-2004 J95-4004 W95-0103
Bolstered by the success of (Stetina and Nagao, 1997), (Lin, 1997) and especially (Stetina et al., 1998), we believe there is great promise the incorporation of word-sense into a probabilistic parsing model.
P97-1009 W97-0109 W98-0701
For brevity, we omit the smoothing details of BBN's model (see (Miller et al., 1998) for a complete description); we note that all smoothing weights are computed via the technique described in (Bikel et al., 1997).
A97-1029
(Stetina and Nagao, 1997) have shown that by employing a fairly simple and somewhat ad-hoc unsupervised method of WSD using a WordNet-based similarity heuristic, they could enhance PP-attachment performance to a significantly higher level than systems that made no use of lexical semantics (88.1% accuracy).
W97-0109
(Yarowsky, 1995) also uses wide context, but incorporates the one-senseper-discourse and one-sense-per-collocation constraints, using an unsupervised learning technique.
P95-1026
The supervised technique in (Yarowsky, 1994) has a more specific notion of context, employing not just words that can appear within a window of Ik, but crucially words that abut and fall in the ~2 window of the target word.
P94-1013
We now present the top-level generation probabilities, along with examples from 4The inclusion of the word feature in the BBN model was due to the work described in (Weischedel et al., 1993), where word features helped reduce part of speech ambiguity for unknown words.
J93-2006
Related to this issue, we note that the head rules, which were nearly identical to those used in (Collins, 1997), have not been tuned at all to this task.
P97-1003
As pointed out by (Stetina and Nagao, 1997), word sense information can be a proxy for the semanticand world-knowledge we as humans bring to bear on attachment decisions such as these.
W97-0109
Inspired by the PP-attachment work of (Stetina and Nagao, 1997), we use WordNet vl.6 (Miller et al., 1990) as our semantic dictionary, where the hypernym structure provides the basis for semantically-motivated soft clusters.
W97-0109
While it is tempting to compare these results to those of (Stetina et al., 1998), who reported 79.4% overall accuracy on a different, larger test set using their non-discourse model, we note that that was more of an upperbound study, examining how well a WSD algorithm could perform if it had access to goldstandard-perfect parse trees33 By way of further comparison, that algorithm has a feature space similar to the synset-prediction compo1nit is not clear how or why the results of (Stetina et al., 1998) exceeded the reported inter-annotator agreement of the entire corpus.
W98-0701
However, we do have SemCor (Miller et al., 1994), where every noun, verb, adjective and adverb from a 455k word portion of the Brown Corpus has been assigned a WordNet synset.
H94-1046
More recently, (Lin, 1997) has shown how syntactic context, and dependency structures in particular, can be successfully employed for word sense disambiguation.
P97-1009
Finally, we would like to investigate the incorporation of unsupervised methods for WSD, such as the heuristically-based methods of (Stetina and Nagao, 1997) and (Stetina et al., 1998), and the theoretically purer bootstrapping method of (Yarowsky, 1995).
P95-1026 W97-0109 W98-0701
As an example of the lack of such dependencies, in the current model when predicting the attachment of \[bought company \[for million\]\], there is no current dependence between the verb bought and the object of the preposition million--a dependence shown to be useful in virtually all the PP attachment work, and particularly in (Stetina and Nagao, 1997).
W97-0109
(Yarowsky, 1992) uses wide "bag-of-words" contexts with a naive Bayes classifier.
C92-2070
Although it has been very useful to work with the BBN model, we are currently implementing and hope to augment a more state-of-the-art model, vzz., Models 2 and 3 of (Collins, 1997).
P97-1003
