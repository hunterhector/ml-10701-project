Algorithm The TextSeg algorithm (Utiyama and Isahara, 2001) implements a probabilistic approach to determine the most likely segmentation, as briefly described below.
P01-1064
However, unlike Pk and Pprimek, WindowDiff takes into account how many boundaries fall within the window and is penalizing in “how many discrepancies occur between the reference and the system results” rather than “determining how often two units of text are incorrectly labeled 147 as being in different segments” (Pevzner and Hearst, 2002).
J02-1002
The gold standard for thematic segmentations has been kindly provided by (Galley et al., 2003) and has been chosen by considering the agreement between at least three human annotations.
P03-1071
Algorithm The C99 algorithm (Choi, 2000) makes a linear segmentation based on a divisive clustering strategy and the cosine similarity measure between any two minimal units.
A00-2004
Algorithm The TextTiling algorithm was initially developed by Hearst (1997) for segmentation of expository texts into multi-paragraph thematic episodes having a linear, non-overlapping structure (as reflected by the name of the algorithm).
J97-1003
Percent error values are given in the figures and we used the following abbreviations: WD to denote WindowDiff error metric; TextSeg KA to denote the TextSeg algorithm (Utiyama and Isahara, 2001) when the average number of boundaries in the reference data was provided to the algorithm; C99 KA to denote the C99 algorithm (Choi, 2000) when the average number of boundaries in the reference data was provided to the algorithm; N0 to denote the algorithm proposing a segmentation with no boundaries; All to denote the algorithm proposing the degenerate segmentation all boundaries; RK to denote the algorithm that generates a random known segmentation; and RU to denote the algorithm that generates a random unknown segmentation.
A00-2004 P01-1064
Generated Data Choi (2000) designed an artificial dataset, built by concatenating short pieces of texts that have been extracted from the Brown corpus.
A00-2004
of Systems Combinations of different features (derived for example from linguistic, prosodic information) have been explored in previous studies like (Galley et al., 2003) and (Kauchak and Chen, 2005).
P03-1071 W05-0405
Following some of the most prominent discourse theories in literature (Grosz and Sidner, 1986; Marcu, 2000), a hierarchical representation of the thematic episodes can be proposed.
J86-3001
(Ferret, 2002; Choi, 2000; Utiyama and Isahara, 2001).
A00-2004 C02-1033 P01-1064
(Reynar, 1998; Ferret, 2002; Galley et al., 2003).
C02-1033 P03-1071
Pevzner and Hearst (2002) highlighted several problems of the Pk metric.
J02-1002
In this paper, we selected for comparison three systems based merely on the lexical reiteration feature: TextTiling (Hearst, 1997), C99 (Choi, 2000) and TextSeg (Utiyama and Isahara, 2001).
A00-2004 J97-1003 P01-1064
metric Pevzner and Hearst (2002) propose the alternative metric called WindowDiff.
J02-1002
Since it is elusive what mental representations humans use in order to distinguish a coherent text, different surface markers (Hirschberg and Nakatani, 1996; Passonneau and Litman, 1997) and external knowledge sources (Kozima and Furugori, 1994) have been exploited for the purpose of automatic thematic segmentation.
J97-1005 P96-1038
Another issue regarding WindowDiff is that it is not clear “how does one interpret the values produced by the metric” (Pevzner and Hearst, 2002).
J02-1002
