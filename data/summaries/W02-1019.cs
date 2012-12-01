Under The Alignment Error Rates Our unseen test data consisted of 207 FrenchEnglish sentence pairs from the Hansards corpus (Och and Ney, 2000b).
C00-2163 P00-1056
The GIZA++ toolkit (Och and Ney, 2000a) was used for training the IBM-3 models (as in (Och and Ney, 2000b)).
C00-2163 P00-1056
5.4 IBM-3 Word Alignment Models Since the true distribution over alignments is not known, we used the IBM-3 statistical translation model (Brown et al., 1993) to approximate . This model is specified through four components: Fertility probabilities for words; Fertility probabilities for NULL; Word Translation probabilities; and Distortion probabilities.
J93-2003
2 Word-to-Word Bitext Alignment We will study the problem of aligning an English sentence to a French sentence and we will use the word alignment of the IBM statistical translation models (Brown et al., 1993).
J93-2003
Metrics The performance of the four decoders was measured with respect to the alignments provided by human experts (Och and Ney, 2000b).
C00-2163 P00-1056
The development of techniques in all these areas would be facilitated by automatic performance metrics, and alignment and translation quality metrics have been proposed (Och and Ney, 2000b; Papineni et al., 2002).
C00-2163 P00-1056
In addition to the reference alignment, this gives a set of sure links (S) which is a subset of . AER is defined as (Och and Ney, 2000b) (1) Since our modeling techniques require loss functions rather than error rates, we introduce the Alignment Error loss function (2) We consider error rates to be “normalized” loss functions.
C00-2163 P00-1056
If POS denotes the POS of the English word, we can define the word-to-word distance measure (Equation 4) as POS POS (15) Ratnaparkhi’s POS tagger (Ratnaparkhi, 1996) was used to obtain POS tags for each word in the English sentence.
W96-0213
To obtain these distances, Ratnaparkhi’s partof-speech (POS) tagger (Ratnaparkhi, 1996) and Collins’ parser (Collins, 1999) were used to obtain parse trees for the English side of the test corpus.
W96-0213
Error The Alignment Error Rate (AER) introduced by Och and Ney (2000b) measures the fraction of links by which the automatic alignment differs from the reference alignment.
C00-2163 P00-1056
The IBM-3 models were trained on a subset of the Canadian Hansards French-English data which consisted of 50,000 parallel sentences (Och and Ney, 2000b).
C00-2163 P00-1056
Recent work (Hwa et al., 2002) suggests that translational corresponence of linguistic structures can indeed be useful in projecting parses across languages.
P02-1050
