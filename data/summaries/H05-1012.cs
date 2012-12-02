As in (Cherry and Lin, 2003), the above functions simplify the conditioning portion, h by utilizing only the words and context involved in the link li.
P03-1012
Experiments The experiments in machine translation are carried out on a phrase based decoder similar to the one de94 MT03 MT04 MT05 GIZA++ 0.454 — — HMM 0.459 0.419 0.456 MaxEnt 0.468 0.433 0.451 Combined 0.479 0.437 0.465 Significance 0.017 0.020 — Table 5: Machine Translation Performance using the NIST 2005 Bleu scorer scribed in (Tillmann and Ney, 2003).
J03-1005
Moore. 2004.
P04-1066
The IBM models 1-5 (Brown et al., 1993) produce word alignments with increasing algorithmic complexity and performance.
J93-2003
Current state of the art machine translation systems (Och, 2003) use phrasal (n-gram) features extracted automatically from parallel corpora.
J03-1002 P03-1021
These IBM models and more recent refinements (Moore, 2004) as well as algorithms that bootstrap from these models like the HMM algorithm described in (Vogel et al., 1996) are unsupervised algorithms.
C96-2141 P04-1066
In order to measure alignment performance, we use the standard AER measure (Och and Ney, 2000) but consider all links as sure.
P00-1056
(Cherry and Lin, 2003) recently proposed a direct alignment formulation and state that it would be straightforward to estimate the parameters given a supervised alignment corpus.
P03-1012
(Berger et al., 1996)), 1We are overloading the word ‘state’ to mean Arabic word position.
J96-1002
Although there is a modest cost associated with annotating data, we show that a reduction of 40% relative in alignment error (AER) is possible over the GIZA++ aligner (Och and Ney, 2003).
J03-1002 P03-1021
Extraction Once an alignment is obtained, phrases which satisfy the inverse projection constraint are extracted (although earlier this constraint was called consistent alignments (Och et al., 1999)).
W99-0604
Segmentation Features An Arabic segmenter similar to (Lee et al., 2003) provides the segmentation features.
P03-1051
The basic intuition behind this feature is that words inside prepositional phrases tend to align, which is similar to the dependency structure feature of (Cherry and Lin, 2003).
P03-1012
