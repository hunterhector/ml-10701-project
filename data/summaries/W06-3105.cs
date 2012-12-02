The system follows the structure proposed in the documentation for the Pharaoh decoder and uses many publicly available components (Koehn, 2003b).
N03-1017
Specifically, in the task of word alignment, heuristic approaches such as the Dice coefficient consistently underperform their re-estimated counterparts, such as the IBM word alignment models (Brown et al., 1993).
J93-2003
One particularly surprising result is that a simple heuristic extraction algorithm based on surface statistics of a word-aligned training set outperformed the phrase-based generative model proposed by Marcu and Wong (2002).
W02-1018
Pharaoh performed decoding using a set of default parameters for weighting the relative influence of the language, translation and distortion models (Koehn, 2003b).
N03-1017
The central difference is that phrase-based models, such as the ones presented in section 2 or Marcu and Wong (2002), contain an element of segmentation.
W02-1018
Koehn et al.(2003a) showed that translation quality is very sensitive to how this table is extracted from the training data.
N03-1017
Unlike previous attempts to train a similar model (Marcu and Wong, 2002), we allow information from a word-alignment model to inform our approximation.
W02-1018
While the model and training regimen for φEM differ from the model from Marcu and Wong (2002), we achieved results similar to Koehn et al.(2003a): φEM slightly underperformed φH.
N03-1017 W02-1018
While similar to the joint model in Marcu and Wong (2002), our model takes a conditional form compatible with the statistical assumptions used by the Pharaoh decoder.
W02-1018
