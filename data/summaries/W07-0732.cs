Although widely popular thanks to their speed and efficiency, both BLEU and NIST have been criticized for inadequate accuracy of evaluation at the segment level (Callison-Burch et al., 2006).
E06-1032
However, automatic measures also have big disadvantages; (Callison-Burch et al., 2006) describes some of them.
E06-1032
Acknowledgments We would like to thank Michel Simard, Roland Kuhn, George Foster and Pierre Isabelle from NRC, Canada for their collaboration on this work (Simard et al.2007). References Attns (M.), Senellart (P).
W07-0728
Simard et al.(2007) have recently shown how a statistical phrase-based machine translation system can be used as an automatic post-editing (APE) layer, on top of a rule-based machine translation system.
W07-0728
One experiment was run by NRC using the language pair English<>French in the context of  Automatic Post-Edition  systems using the PORTAGE system as described in Simard et al.(2007). The second experiment based on the same principle was run on the German>English and Spanish>English1 language pairs using the Moses system (Koehn et al.2007). The objective was to train a SMT system on a parallel corpus composed of SYSTRAN translations with the referenced source aligned with its referenced translation.
W07-0728
However, recent work suggests that Bleu?s correlation with human judgments may not be as strong as previously thought (Callison-Burch et al., 2006).
E06-1032
This is the type of data that was used in the initial study of Simard et al.(2007). Unfortunately, this sort of training data is seldom available.
W07-0728
Edinburgh, UK (Dugast et al., 2007) systran-nrc National Research Council, Canada (Simard et al., 2007) ucb University of California at Berkeley, USA (Nakov and Hearst, 2007) uedin University of Edinburgh, UK (Koehn and Schroeder, 2007) umd University of Maryland, USA (Dyer, 2007) upc University of Catalonia, Spain (Costa-Juss`a and Fonollosa, 2007) upv University of Valencia, Spain (Civera and Juan, 2007) Table 1: Participants in the shared task.
W07-0728
This is akin to post-editing (though definitely not akin to the much more sophisticated approach in described in Simard et al.(2007)). We proceeded as follows: We used the selective segmentation based model above and decoded our English training data ETrain and English test data ETest to obtain T1Train and T1Test reStep BLEU From Table 4 24.61 Iter.
W07-0728
The interested reader is referred to (Simard et al., 2007).
W07-0728
Callison-Burch et al.(2006) extract phrase-level paraphrases by mapping input phrases into a phrase table and then mapping back to the source language.
E06-1032
Chris Callison-Burch, Miles Osborne and Philipp Koehn, 2006.
E06-1032
As suggested by Callison-Burch et al.(2006) we perform a focussed manual analysis of the output to see what changes have occurred.
E06-1032
3 3 Related work 3.1 String-based metrics The insensitivity of BLEU and NIST to perfectly legitimate syntactic and lexical variation has been raised, among others, in Callison-Burch et al.(2006), but the criticism is widespread.
E06-1032
