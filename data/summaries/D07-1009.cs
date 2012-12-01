3Independently and simultaneously with our work, Elsner and Charniak (2007) have studied the sentence insertion task in a different setting.
N07-1055
To make sentencelevel insertion decisions, we use a local model in line with previous sentence-ordering work (Lapata, 2003; Bollegala et al., 2006).
P03-1069 P06-1049
To identify the exact location of the sentence within the chosen paragraph, local ordering methods such as (Lapata, 2003) could be used.
P03-1069
For documents where hierarchical information is not explicitly provided, such as automatic speech transcripts, we can use automatic segmentation methods to induce such a structure (Hearst, 1994).
P94-1002
Our hierarchical training method yields significant improvement when compared to a similar nonhierarchical model which instead uses the standard 2Data and code used in this paper are available at http://people.csail.mit.edu/edc/emnlp07/ perceptron update of Collins (2002).
W02-1001
Relative to other corpora used in text structuring research (Barzilay and Lee, 2004; Lapata, 2003; Karamanis et al., 2004), texts in 6Insertion is only one type of recorded update, others include deletions and sentence rewriting.
N04-1015 P03-1069 P04-1050
Features used in our experiments are inspired by previous work on corpus-based approaches for discourse analysis (Marcu and Echihabi, 2002; Lapata, 2003; Elsner et al., 2007).
N07-1055 P02-1047 P03-1069
4Though statistical methods have been used to induce such trees (Soricut and Marcu, 2003), they are not used for ordering and other text-structuring tasks.
N03-1030
This measure was first introduced in the context of sentence ordering by Lapata (2003).
P03-1069
This property distinguishes our corpus from more stylistically homogeneous collections of biographies used in text generation research (Duboue and McKeown, 2003).
W03-1016
In fact, when the perceptron update rule of (Dekel et al., 2004) – which modifies the weights of every divergent node along the predicted and true paths – is used in the ranking framework, it becomes virtually identical with the standard, flat, ranking perceptron of Collins (2002).5 In contrast, our approach shares the idea of (Cesa-Bianchi et al., 2006a) that “if a parent class has been predicted wrongly, then errors in the children should not be taken into account.” We also view this as one of the key ideas of the incremental perceptron algorithm of (Collins and Roark, 2004), which searches through a complex decision space step-by-step and is immediately updated at the first wrong move.
P04-1015 W02-1001
We extract temporal expressions using the TIMEX2 tagger (Mani and Wilson, 2000), and compute the time interval for a paragraph bounded by its earliest and latest dates.
P00-1010
The degree of variability observed in this experiment is consistent with human performance on other text structuring tasks such as sentence ordering (Barzilay et al., 2002; Lapata, 2003).
P03-1069
Work Text Structuring The insertion task is closely related to the extensively studied problem of sentence ordering.3 Most of the existing algorithms represent text structure as a linear sequence and are driven by local coherence constraints (Lapata, 2003; Karamanis et al., 2004; Okazaki et al., 2004; Barzilay and Lapata, 2005; Bollegala et al., 2006; Elsner and Charniak, 2007).
C04-1108 N07-1055 P03-1069 P04-1050 P05-1018 P06-1049
The model weights are trained using the standard ranking perceptron (Collins, 2002).
W02-1001
