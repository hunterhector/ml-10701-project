Results To understand the behavior of this model, we computed the standard alignment error rate (AER) performance metric.2 We also investigated extractionspecific metrics: the frequency of interior nodes – a measureofhowoftenthealignmentsviolatetheconstituent structure of English parses – and a variant of the CPER metric of Ayan and Dorr (2006).
P06-1002
A host of discriminative methods have been introduced (Taskar et al., 2005; Moore, 2005; Ayan and Dorr, 2006).
H05-1010 H05-1011 P06-1002
Unsupervised methods have seen substantial reductions in alignment error (Liang et al., 2006) as measured by the now much-maligned AER metric.
N06-1014
We also compared our French results to the public baseline GIZA++ using the script published for the NAACL 2006 Machine Translation Workshop Shared Task.5 Similarly, we compared our Chinese results to the GIZA++ results in Ayan and Dorr (2006).
P06-1002
Moore. 2005.
H05-1011
Syntactic methods are an increasingly promising approach to statistical machine translation, being both algorithmically appealing (Melamed, 2004; Wu, 1997) and empirically successful (Chiang, 2005; Galley et al., 2006).
J97-3002 P06-1121
Och and Ney (2003) gives a detailed exposition of the technique.
J03-1002
Posterior Inference Liang et al.(2006) shows that thresholding the posterior probabilities of alignments improves AER relative to computing Viterbi alignments.
N06-1014
We are particularly motivated by systems like the one described in Galley et al.(2006), which constructs translations using tree-to-string transducer rules.
P06-1121
Liang et al.(2006) suggests a soft intersection of a model m with a reverse model r (foreign to English) that thresholds the product of their posteriors at each position: a = {(i,j) : pm(aj = i|f,e)·pr(ai = j|f,e) > τ}.
N06-1014
with Tree Transducers In a tree transducer system, as in phrase-based systems, the coverage and generality of the transducer inventory is strongly related to the effectiveness of the translation model (Galley et al., 2006).
P06-1121
Formally, our model describes p(a,f|e,t), but otherwise borrows heavily from the HMM alignment model of Ney and Vogel (1996).
C96-2141
Using the joint training technique of Liang et al.(2006) to initialize the model parameters, we achieve an AER superior to the GIZA++ implementation of IBM model 4 (Och and Ney, 2003) and a reduction of 56.3% in aligned interior nodes, a measure of agreement between alignments and parses.
J03-1002 N06-1014
Our models substantially outperform GIZA++, confirming results in Liang et al.(2006). Table 2 shows the effect on AER of competitive thresholding and different combination functions.
N06-1014
This dependence runs deep; for example, Galley et al.(2006) requires word alignments to project trees from the target language to the source, while Chiang (2005) requires alignments to induce grammar rules.
P06-1121
Additionally, we evaluated our model with the transducer analog to the consistent phrase error rate (CPER)metricofAyanandDorr(2006).
P06-1002
Using the simple but effective joint training technique of Liang et al.(2006), we initialized the model with lexical parameters from a jointly trained implementation of IBM Model 1.
N06-1014
Lopez and Resnik (2005) considers a simpler tree distance distortion model.
W05-0812
We present and evaluate an unsupervised word alignment model similar in character and computation to the HMM model (Ney and Vogel, 1996), but which incorporates a novel, syntax-aware distortion component which conditions on target language parse trees.
C96-2141
∗From Ayan and Dorr (2006), grow-diag-final heuristic.
P06-1002
For Chinese, we trained on the FBIS corpus and the LDC bilingual dictionary, then tested on 491 hand-aligned sentences from the 2002 2The hand-aligned test data has been annotated with both sure alignments S and possible alignments P, with S ⊆ P, according to the specifications described in Och and Ney (2003).
J03-1002
However, few of these methods have explicitly addressed the tension between word alignments and the syntactic processes that employ them (Cherry and Lin, 2006; Daum´e III and Marcu, 2005; Lopez and Resnik, 2005).
P06-2014 W05-0812
