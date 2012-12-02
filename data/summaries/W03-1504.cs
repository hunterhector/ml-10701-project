Spanish resources In this section we extend our previous work on NE recognition (Carreras et al., 2003) to obtain a bilingual NE classification model.
E03-1038
The strategy used for training the bilingual NE classification models has been also applied with good results to NE recognition in (Carreras et al., 2003), a work that can be considered complementary to this one.
E03-1038
for this specific task in (Abney, 2002).
P02-1046
More recent approaches can be found in the proceedings of the shared task at the 2002 and 2003 editions of the Conference on Natural Language Learning (Tjong Kim Sang, 2002; Tjong Kim Sang and De Meulder, 2003), where several machine–learning (ML) systems were compared at the NERC task for several languages.
W02-2024 W03-0419
These results are comparable to the ones presented in (Abney, 2002), taking into account, apart from the language change, that we have introduced a fourth class to be treated the same as the other three.
P02-1046
This technique is exactly the same we proposed to learn a Catalan–Spanish bilingual NE recognition module (Carreras et al., 2003).
E03-1038
Additionally, a NERC system based on the AdaBoost algorithm obtained the best results in the CoNLL’02 Shared Task competition (Carreras et al., 2002).
W02-2004
Abney. 2002.
P02-1046
This is one of the main causes for the recent growing interest on developing language– independent NERC systems, which may be trained from small training sets by taking advantage of unlabelled examples (Collins and Singer, 1999; Abney, 2002), and which are easy to adapt to changing domains (being all these aspects closely related).
P02-1046 W99-0613
They have been used in some previous works allowing significant improvements for the Spanish NERC task (Carreras et al., 2002; Carreras et al., 2003).
E03-1038 W02-2004
The first, suggested in (Collins and Singer, 1999; Abney, 2002), divides into one view capturing internal features of the NE, and the other capturing features of its left-right contexts (hereafter referred to as Greedy Agreement pure, or GAa16 ).
P02-1046 W99-0613
Third, how the algorithm, presented in (Abney, 2002) for binary classification, can be extended to a multiclass problem.
P02-1046
See (Abney, 2002) for a formal proof that this algorithm tends to gradually reduce the classification error given the adequate seed rules.
P02-1046
Learning We have implemented the Greedy Agreement Algorithm (Abney, 2002) which, based on two independent views of the data, is able to learn two binary classifiers from a set of hand-typed seed rules.
P02-1046
