Taskar et al.(2005) reported 5.4% AER for a discriminative model that includes predictions from the intersection of IBM Model 4 alignments as a feature.
H05-1010
Until recently, almost all work in statistical machine translation was based on word alignments obtained from combinations of generative probabalistic models developed at IBM by Brown et al.(1993), sometimes augmented by an HMMbased model or Och and Ney’s “Model 6” (Och and Ney, 2003).
J03-1002 J93-2003
Training We optimize feature weights using a modification of averaged perceptron learning as described by Collins (2002).
W02-1001
Automatic sentence alignment of the training data was provided by Ulrich Germann, and the hand alignments of the labeled data were created by Franz Och and Hermann Ney (Och and Ney, 2003).
J03-1002
Approach As in our previous work (Moore, 2005), we train two models we call stage 1 and stage 2, both in the form of a weighted linear combination of feature values extracted from a pair of sentences and a proposed word alignment of them.
H05-1011
Perceptron training has been shown to obtain good results for some problems, but occasionally very poor results are reported, notably by Taskar et al.(2005) for the word-alignment problem.
H05-1010
lexical features Taskar et al.(2005) gain considerable benefit by including features counting the links between particular high frequency words.
H05-1010
We used the same training and test data as in our previous work, a subset of the Canadian Hansards bilingual corpus supplied for the bilingual word alignment workshop held at HLT-NAACL 2003 (Mihalcea and Pedersen, 2003).
W03-0301
The best previously reported result was by Och and Ney (2003), who obtained 5.2% AER for a combination including all the IBM models except Model 2, plus the HMM model and their Model 6, together with a bilingual dictionary, for the refined alignment combination, trained on three times as much data as we used.
J03-1002
In 2005, however, several independent efforts (Liu et al., 2005; Fraser and Marcu, 2005; Ayan et al., 2005; Taskar et al., 2005; Moore, 2005; Ittycheriah and Roukos, 2005) demonstrated that discriminatively trained models can equal or surpass the alignment accuracy of the standard models, if the usual unlabeled bilingual training corpus is supplemented with human-annotated word alignments for only a small subset of the training data.
H05-1009 H05-1010 H05-1011 H05-1012 P05-1057 W05-0814
Cherry and Lin’s (2003) method obtained an AER of 5.7% as reported by Mihalcea and Pedersen (2003), the previous lowest reported error rate for a method that makes no use of the IBM models.
P03-1012 W03-0301
package, using the default configuration file (Och and Ney, 2003).2 “Prev LLR” is our earlier stage 1 model, and CLP1 and CLP2 are two versions of our earlier stage 2 model.
J03-1002
Their best result, however, is obtained from a model that includes both a feature recording intersected IBM Model 4 predictions, plus a feature whose values are the alignment probabilities obtained from a pair of HMM alignment models trained in both directions in such a way that they agree on the alignment probabilities (Liang et al., 2006).
N06-1014
The principal training method is an adaptation of averaged perceptron learning as described by Collins (2002).
W02-1001
After completing the experiments described in Section 7, we became aware further developments in the line of research reported by Taskar et al.(Lacoste-Julien et al., 2006).
N06-1015
We take advantage of this, building on our existing framework (Moore, 2005), to substantially reduce the alignment error rate (AER) we previously reported, given the same training and test data.
H05-1011
Results for IBM Model 4 are reported for models trained in both directions, English-to-French and French-toEnglish, and for the union, intersection, and what Och and Ney (2003) call the “refined” combination of the those two alignments.
J03-1002
Moore. 2005.
H05-1011
