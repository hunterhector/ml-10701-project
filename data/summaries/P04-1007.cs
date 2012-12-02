of n-gram language models An n-gram model can be efficiently represented in a deterministic WFA, through the use of failure transitions (Allauzen et al., 2003).
P03-1006
See Allauzen et al.(2003) for more details.
P03-1006
The GRM library, which was presented in Allauzen et al.(2003), has a direct implementation of the function ExpCount, which simultaneously calculates the expected value of all n-grams of order less than or equal to a given n in a latticeL.
P03-1006
linear models We follow the framework outlined in Collins (2002; 2004).
W02-1001
This technique has been shown to be very effective in a variety of NLP tasks (Malouf, 2002; Wallach, 2002).
W02-2018
Freund and Schapire (1999) originally proposed the averaged parameter method; it was shown to give substantial improvements in accuracy for tagging tasks in Collins (2002).
W02-1001
Following Collins (2002), we used the averaged parameters from the training algorithm in decoding heldout and test examples in our experiments.
W02-1001
Random Fields Conditional Random Fields have been applied to NLP tasks such as parsing (Ratnaparkhi et al., 1994; Johnson et al., 1999), and tagging or segmentation tasks (Lafferty et al., 2001; Sha and Pereira, 2003; McCallum and Li, 2003; Pinto et al., 2003).
N03-1028 P99-1069 W03-0430
Following Johnson et al.(1999) and Lafferty et al.(2001), we use a zero-mean Gaussian prior on the parameters resulting in the regularized objective function: LLR( ) = NX i=1 [ (xi;yi) logZ(xi; )] jj jj 2 2 2 (3) The value dictates the relative influence of the loglikelihood term vs.
P99-1069
