Feature function weights in the loglinear model are set using Och’s minium error rate algorithm (Och, 2003).
P03-1021
The phrasebased translation model is similar to that of Koehn, with the exception that phrase probability estimates P (˜s|˜t) are smoothed using the Good-Turing technique (Foster et al., 2006).
W06-1607
The advent of Statistical Machine Translation, and most recently phrase-based approaches (PBMT, see Marcu and Wong (2002), Koehn et al.(2003)) into the commercial arena seems to hold the promise of a solution to this problem: because the MT system learns directly from existing translations, it can be automatically customized to new domains and tasks.
N03-1017 W02-1018
Portage is a phrase-based, statistical machine translation system, developed at the National Research Council of Canada (NRC) (Sadat et al., 510 2005).
W05-0822
To improve raw output from decoding, Portage relies on a rescoring strategy: given a list of n-best translations from the decoder, the system reorders this list, this time using a more elaborate loglinear model, incorporating more feature functions, in addition to those of the decoding model: these typically include IBM-1 and IBM-2 model probabilities (Brown et al., 1993) and an IBM-1-based feature function designed to detect whether any word in one language appears to have been left without satisfactory translation in the other language; all of these feature functions can be used in both language directions, i.e. source-to-target and target-to-source.
J93-2003
