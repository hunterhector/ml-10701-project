Based on an earlier combination study (Tjong Kim Sang, 2000) we had expected the voting methods to do better.
A00-2007
(1998) and Brill and Wu (1998) show that part-ofst)ee(:h tagger l)erformance can 1)e iml)roved 1)y (:oml)ining ditl'erent tatters.
P98-1029
861 section 20 accuracy precision recall Best-five combination 0:98.32% C:98.41% 94.18% 93.55% Tjong Kim Sang (2000) O:98.10% C:98.29% 93.63% 92.89% Mufioz et al.(1999) O:98.1% C:98.2% 92.4% 93.1% Ramshaw and Marcus (1995) IOB1:97.37% 91.80% 92.27% Argamon et al.(1999) 91.6% 91.6% F/3=1 93.86 93.26 92.8 92.03 91.6 Table 3: The overall pertbrmance of the majority voting combination of our best five systems (selected on tinting data perfbrnmnce) applied to the standard data set pnt tbrward by Ramshaw and Marcus (1995) together with an overview of earlier work.
A00-2007 W95-0107
He used the Ramshaw and Marcus (1995) representation as well (IOB1).
W95-0107
The approach we have chosen here is the same as in Tjong Kim Sang (2000): generate different variants of the task by using different representations of the output (IOB1, IOB2, IOE1, IOE2 and O+C).
A00-2007
We expect the systems which use this combination phase to perform better than their individuM members (Tjong Kim Sang, 2000).
A00-2007
An alternative representation for baseNPs has been put tbrward by Ramshaw and Marcus (1995).
W95-0107
been put forward by Ramshaw and Marcus (1995).
W95-0107
The data contains words, their part-of-speech 1This Ramshaw and Marcus (1995) bascNP data set is availal)le via ffp://fti).cis.upe,m.edu/pub/chunker/ 857 (POS) tags as computed by the Brill tagger and their baseNP segmentation as derived from the %'eebank (with some modifications).
W95-0107
However, we have not used the combination strategy from Mufioz et al.(1999) trot instead used the strategy outlined in Tjong Kim Sang (2000): regard only the shortest possible phrases between candidate open and close brackets as base noun phrases.
A00-2007
Like the data used by Ramshaw and Marcus (1995), this data was retagged by the Brill tagger in order to obtain realistic part-of speech (POS) tags 5.
W95-0107
The data was seglnente.d into baseNP parts and non-lmseNP t)arts ill a similar fitshion as the data used 1)y Ramshaw and Marcus (1995).
W95-0107
For every class the weights of the active features are combined and the best scoring class is chosen (Berger et al., 1996).
J96-1002
t~i)r |;lie four IO representations we have used a second i)rocessing stage which used a smaller context lint which included information at)out the IO tags 1)redicted by the first processing phase (Tjong Kim Sang, 2000).
A00-2007
