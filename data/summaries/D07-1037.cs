Approximating Lexical Chains One of the motivations for our cohesion score is that it approximates lexical chains, as for example in (Galley et al., 2003).
P03-1071
Topic segmentation approaches use either sentences (Galley et al., 2003) or blocks of words as text units (Hearst, 1994).
P03-1071 P94-1002
1http://www1.cs.columbia.edu/ galley/tools.html 2http://nist.gov/speech/tests/tdt/tdt98/ 3http://www.lemurproject.org/ 4http://www.cis.upenn.edu/ dbikel/software.html Evaluation For the TDT data we use the error metric pk (Beeferman et al., 1999) and WindowDiff (Pevzner and Hearst, 2002) which are implemented in the LCseg toolkit.
J02-1002
Hearst. 1994.
P94-1002
5.1 Data The first TDT collection is part of the LCseg toolkit1 (Galley et al., 2003) and we used it to compare our approach to LCseg.
P03-1071
We compare our approach to the LCseg algorithm (Galley et al., 2003) and use sentences as segmentation unit.
P03-1071
Averaged similarity In our preliminary experiments we used the largest difference in score to predict story boundary, following the TextTiling approach (Hearst, 1994).
P94-1002
This can be done either by analyzing the number of overlapping lexical chains (Hearst, 1994) or by building a short-range and long-range language model (Beeferman et al., 1999).
P94-1002
(Choi et al., 2001) used clustering to predict boundaries whereas we used the average similarity scores.
W01-0514
More recently, topic segmentation with lexical chains has been successfully applied to segmentation of news stories, multi-party conversation and audio recordings (Galley et al., 2003).
P03-1071
(Choi et al., 2001) used all vocabulary words to compute low-dimensional document vectors.
W01-0514
We tried other parameter values but did not achieve better performance, which is consistent with other research (Hearst, 1994; Galley et al., 2003).
P03-1071 P94-1002
used LSA for segmentation (Choi et al., 2001).
W01-0514
Therefore, many approaches have concentrated on different ways of estimating lexical coherence of text segments, such as semantic similarity between words (Kozima, 1993), similarity between blocks of text (Hearst, 1994), and adaptive language models (Beeferman et al., 1999).
P93-1041 P94-1002
Approaches We compare our approach to the LCseg algorithm which uses lexical chains to estimate topic boundaries (Galley et al., 2003).
P03-1071
GLSA extends the ideas of LSA by defining different ways to obtain the similarities matrix and has been shown to outperform LSA on a number of applications (Matveeva and Levow, 2006).
W06-3810
Galley et al.(Galley et al., 2003) define lexical chains R1,..,RN by considering repetitions of terms t1,..,tN and assigning larger weights to short and compact chains.
P03-1071
The variant of the TDT corpus we used is rather small and wellbalanced, see (Galley et al., 2003) for details.
P03-1071
