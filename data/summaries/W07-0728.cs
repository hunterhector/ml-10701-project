Simard et al.(2007) have recently shown how a statistical phrase-based machine translation system can be used as an automatic post-editing (APE) layer, on top of a rule-based machine translation system.
N07-1064
They are generated from the training corpus via the ?diag-and??method (Koehn et al., 2003) and smoothed using Kneser-Ney smoothing (Foster et al., 2006), ??one or several n-gram language model(s) trained with the SRILM toolkit (Stolcke, 2002); in the baseline experiments reported here, we used a trigram model, ??a distortion model which assigns a penalty based on the number of source words which are skipped when generating a new target phrase, ??a word penalty.
W06-1607
The raw rel197 ative frequency estimates found in the phrase translation tables are then smoothed by applying modified Kneser-Ney discounting as explained in (Foster et al., 2006).
W06-1607
The interested reader is referred to (Simard et al., 2007).
N07-1064
Approach Before going into details of our approach, an overview of Portage (Sadat et al, 2005), the machine translation system that we used for our experiments and some of its properties should be provided.
W05-0822
Edinburgh, UK (Dugast et al., 2007) systran-nrc National Research Council, Canada (Simard et al., 2007) ucb University of California at Berkeley, USA (Nakov and Hearst, 2007) uedin University of Edinburgh, UK (Koehn and Schroeder, 2007) umd University of Maryland, USA (Dyer, 2007) upc University of Catalonia, Spain (Costa-Juss`a and Fonollosa, 2007) upv University of Valencia, Spain (Civera and Juan, 2007) Table 1: Participants in the shared task.
N07-1064 W07-0732
This operation is conceptually not very different from a target-to-target translation; for this task, we used the PORTAGE system, a state-of-the-art statistical phrase-based machine translation system developed at the National Research Council of Canada (NRC).1 A general description of PORTAGE can be found in (Sadat et al., 2005).
W05-0822
We speculated that this may have been due to non-smooth component models, and tried various smoothing schemes, including Kneser-Ney phrase table smoothing similar to that described in (Foster et al., 2006), and binary features to indicate phrasepair presence within different components.
W06-1607
This is akin to post-editing (though definitely not akin to the much more sophisticated approach in described in Simard et al.(2007)). We proceeded as follows: We used the selective segmentation based model above and decoded our English training data ETrain and English test data ETest to obtain T1Train and T1Test reStep BLEU From Table 4 24.61 Iter.
N07-1064
First, we used several types of phrase table smoothing in the WMT 2007 system because this proved helpful on other translation tasks: relative frequency estimates, Kneser-Neyand Zens-Ney-smoothed probabilities (Foster et al., 2006).
W06-1607
ability estimate, a standard frequency-based conditional probability estimate, and variants thereof based on different smoothing methods (Foster et al., 2006).
W06-1607
This is the type of data that was used in the initial study of Simard et al.(2007). Unfortunately, this sort of training data is seldom available.
N07-1064
A detailed overview of SYSTRAN systems can be found in Dugast et al.(2007). For this shared task, we used the French-to-English and English-to-French con gurations of the system.
W07-0732
In Proceedings 23 of the 40th Annual Conference of the Association for Computational Linguistics (ACL), Philadelphia, PA Fatiha Sadat, Howard Johnson, Akakpo Agbago, George Foster, Roland Kuhn, Aaron Tikuisis, 2005.
W05-0822
