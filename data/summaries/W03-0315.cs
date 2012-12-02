A bilingual sentence alignment program (Gale and Church, 1991, and Brown et al., 1991) is the crucial part in this adaptation procedure, in that it collects bilingual document pairs from the Internet, and identifies sentence pairs, which should have a high likelihood of being correct translations of each other.
P91-1022 P91-1023
1991. Melamed, I.D. 1996.
W96-0201
∑∑ ∑ == = = l i i m j jl k k ss eeff eft eft efefc 11 1 )()( ),(),( )|( )|( ),;|( δδ With the conditional probability t(f|e), the probability for an alignment of foreign string F given English string E is in (1): ∏∑ = = + = m j n i ijm eft l EFP 1 0 )|( )1( 1 )|( (1) The probability of alignment F given E: )|( EFP is shown to achieve the global maximum under this EM framework as stated in (Brown et al.,1993). In our approach, equation (1) is further normalized so that the probability for different lengths of F is comparable at the word level: m m j n i ijm eft l EFP /1 10 )|( )1( 1 )|(       + = ∏∑ == (2) The alignment models described in (Brown et al., 1993) are all based on the notion that an alignment aligns each source word to exactly one target word.
J93-2003
The components in our system include: • A web crawler, which collects potential parallel html documents based on link information following (Philip Resnik 1999); • A bilingual html parser (based on flex for efficiency), which is designed for both Chinese and English html documents.
P99-1068
Translation Lexicon We use a statistical translation lexicon known as IBM Model-1 in (Brown et al., 1993) for both efficiency and simplicity.
J93-2003
Length Models As was shown in the sentence alignment literature (Church, K.W. 1993), the sentence length ratio is also a very good indication of the alignment of a sentence pair for languages from a similar family such as French and English.
P93-1001
The difference of the length |)||,(| tsδ is assumed to be a Gaussian distribution (Church, K.W. 1993) and can be normalized as follows: )1,0(~ )1|(| |||| 2 N s cst σ δ + − = (4) where c is a constant indicating the mean length ratios between source and target sentences and 2 σ is the variance of the length ratios.
P93-1001
