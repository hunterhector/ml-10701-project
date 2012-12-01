Previous investigations can be found in works such as (Gale and Church, 1993) and (Ma, 2006).
J93-1004
An alternative method (Wu, 1997) makes decisions at the end but has a high computational requirement.
J97-3002
Another approach is the binary segmentation method described in (Simard and Langlais, 2003), (Xu et al., 2005) and (Deng et al., 2006), which separates a long sentence pair into two sub-pairs recursively.
W03-0304
(Papineni et al., 2002).
P02-1040
Monotone Nonmonotone Target B A Positions C D Source Positions Figure 1: Two Types of Alignment The IBM model 1 (IBM-1) (Brown et al., 1993) assumes that all alignments have the same probability by using a uniform distribution: p(fJ1 |eI1) = 1IJ · Jproductdisplay j=1 Isummationdisplay i=1 p(fj|ei) (2) We use the IBM-1 to train the lexicon parameters p(f|e), the training software is GIZA++ (Och and Ney, 2003).
J03-1002 J93-2003
