traditional IBM alignment model IBM Model 4 (Brown et al., 1993) learns a set of 4 probability tables to compute p(f|e) given a foreign sentence f and its target translation e via the following (greatly simplified) generative story: 361 NP-C NPB NPB NNP taiwan POS ’s NN surplus PP IN in NP-C NPB NN trade PP IN between NP-C NPB DT the CD two NNS shores FTD0 GR G4E7 DYBG EL DIDV TAIWAN IN TWO-SHORES TRADE MIDDLE SURPLUS R1: NP-C NPB x0:NPB x1:NN x2:PP →x0 x2EL x1 R10: NP-C NPB x0:NPB x1:NN x2:PP →x0 x2 x1 R10: NP-C NPB x0:NPB x1:NN x2:PP →x0 x2 x1 R2: NPB NNP taiwan POS ’s →FTD0 R11: NPB x0:NNP POS ’s →x0 R17: NPB NNP taiwan x0:POS →x0 R12: NNP taiwan →FTD0 R18: POS ’s →FTD0 R3: PP x0:IN x1:NP-C →x0 x1 R13: PP IN in x0:NP-C →GR x0EL R19: PP IN in x0:NP-C →x0 R4: IN in → GR R5: NP-C x0:NPB x1:PP → x1 x0 R5: NP-C x0:NPB x1:PP →x1 x0 R20: NP-C x0:NPB PP x1:IN x2:NP-C →x2 x0 x1 R6: PP IN between NP-C NPB DT the CD two NNS shores →G4E7 R14: PP IN between x0:NP-C →x0 R21: IN between →EL R15: NP-C x0:NPB →x0 R15: NP-C x0:NPB →x0 R16: NPB DT the CD two NNS shores →G4E7 R22: NPB x0:DT CD two x1:NNS →x0 x1 R23: NNS shores →G4E7 R24: DT the →GR R7: NPB x0:NN →x0 R7: NPB x0:NN →x0 R7: NPB x0:NN →x0 R8: NN trade →DYBG R9: NN surplus →DIDV R8: NN trade →DYBG R9: NN surplus →DIDV R8: NN trade →DYBG R9: NN surplus →DIDV Figure 2: A (English tree, Chinese string) pair and three different sets of multilevel tree-to-string rules that can explain it; the first set is obtained from bootstrap alignments, the second from this paper’s re-alignment procedure, and the third is a viable, if poor quality, alternative that is not learned.
J93-2003
re-alignment setup We begin with a training corpus of Chinese-English and Arabic-English bitexts, the English side parsed by a reimplementation of the standard Collins model (Bikel, 2004).
J04-4004
We initially attempted to use the top-down DERIV algorithm of Graehl and Knight (2004), but as the constraints of the derivation forests are largely lexical, too much time was spent on exploring deadends.
N04-1014
Binarize rules using the synchronous binarization algorithm for tree-to-string transducers described in Zhang et al.(2006). 2.
N06-1033
Such an algorithm is presented by Graehl and Knight (2004).
N04-1014
Examples of realistic systems are the phrase-based ATS system of Och and Ney (2004), the phrasal-syntax hybrid system Hiero (Chiang, 2005), and the GHKM syntax system (Galley et al., 2004; Galley et al., 2006).
J04-4002 P05-1033 P06-1121
However, searching the space of all possible alignments is intractable for EM, so in practice the procedure is bootstrapped by models with narrower search space such as IBM Model 1 (Brown et al., 1993) or Aachen HMM (Vogel et al., 1996).
C96-2141 J93-2003
Some examples of the idealistic approach are the direct IBM word model (Berger et al., 1994; Germann et al., 2001), the phrase-based approach of Marcu and Wong (2002), and the syntax approaches of Wu (1996) and Yamada and Knight (2001).
H94-1028 P01-1030 P01-1067 P96-1021 W02-1018
Marcu and Wong (2002) note this preference but consider the phenomenon a feature, rather than a bug.
W02-1018
If human-aligned data is available, the EMD algorithm provides higher baseline alignments than GIZA++ that have led to better MT performance (Fraser and Marcu, 2006).
P06-1097
For an alignment model, most of these use the Aachen HMM approach (Vogel et al., 1996), the implementation of IBM Model 4 in GIZA++ (Och and Ney, 2000) or, more recently, the semi-supervised EMD algorithm (Fraser and Marcu, 2006).
C96-2141 P00-1056 P06-1097
We obtain weights for the combinations of the features by performing minimum error rate training (Och, 2003) on held-out data.
P03-1021
The actual running of EM iterations (which directly implements the TRAIN algorithm of Graehl and Knight (2004)) 1In the cases where a rule is not synchronous-binarizable standard left-right binarization is performed and proper permutation of the disjoint English tree spans must be verified when building the part of the chart that uses this rule.
N04-1014
Construct a parse chart with a CKY parser simultaneously constrained on the foreign string and English tree, similar to the bilingual parsing of Wu (1997) 1.
J97-3002
2 Multi-level syntactic rules for syntax MT Galley et al.(2004) and Galley et al.(2006) describe a syntactic translation model that relates English trees to foreign strings.
P06-1121
For each experiment we report: the number of rules extracted by the expanded GHKM algorithm of Galley et al.(2006) for the translation model, converged BLEU scores on the tuning set, and finally BLEU performance on the held-out test set.
P06-1121
Galley et al.(2006) provides a more complete description of the translation model and DeNeefe et al.(2007) provides a more complete description of the end-to-end translation pipeline.
D07-1079 P06-1121
Brown et al.(1993) describes an EM algorithm for estimating values for the four tables in the generative story.
J93-2003
Och and Ney (2000) and Fraser and Marcu (2006).
P00-1056 P06-1097
