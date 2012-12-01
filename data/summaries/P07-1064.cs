This model is an appropriate baseline, because it has been shown to compare favorably with other top-performing segmentation systems (Choi et al., 2001; Utiyama and Isahara, 2001).
P01-1064 W01-0514
Baseline We use the state-of-the-art mincut segmentation system by Malioutov and Barzilay (2006) as our point of comparison.
P06-1004
Multiple studies of discourse structure, however, have shown that prosodic cues are highly predictive of changes in topic structure (Hirschberg and Nakatani, 1996; Shriberg et al., 2000).
P96-1038
The central assumption here is that sharp changes in lexical distribution signal the presence of topic boundaries (Hearst, 1994; Choi et al., 2001).
P94-1002 W01-0514
Not surprisingly, a variety of methods for topic segmentation have been developed in the past (Beeferman et al., 1999; Galley et al., 2003; Dielmann and Renals, 2005).
P03-1071
These methods aim to infer vocabulary from unsegmented audio streams by analyzing regularities in pattern distribution (de Marcken, 1996; Brent, 1999; Venkataraman, 2001).
J01-3002
In parallel, researchers extensively study the relationship between discourse structure and intonational variation (Hirschberg and Nakatani, 1996; Shriberg et al., 2000).
P96-1038
Others are specifically adapted for processing speech input by adding relevant acoustic features such as pause length and speaker change (Galley et al., 2003; Dielmann and Renals, 2005).
P03-1071
Set-Up Data We use a publicly available3 corpus of introductory Physics lectures described in our previous work (Malioutov and Barzilay, 2006).
P06-1004
Evaluation Metrics We use the Pk and WindowDiff measures to evaluate our system (Beeferman et al., 1999; Pevzner and Hearst, 2002).
J02-1002
This optimization problem can be solved using one of many unsupervised segmentation approaches (Choi et al., 2001; Ji and Zha, 2003; Malioutov and Barzilay, 2006).
P06-1004 W01-0514
In our implementation, we employ the minimumcut segmentation algorithm (Shi and Malik, 2000; Malioutov and Barzilay, 2006).
P06-1004
