It generates a vector of 5 numeric values for each phrase pair: • phrase translation probability: φ( ¯f|¯e) = count( ¯f, ¯e) count(¯e),φ(¯e| ¯f) = count( ¯f, ¯e) count( ¯f) 2http://www.phramer.org/ – Java-based open-source phrase based SMT system 3http://www.isi.edu/licensed-sw/carmel/ 4http://www.speech.sri.com/projects/srilm/ 5http://www.iccs.inf.ed.ac.uk/∼pkoehn/training.tgz 150 • lexical weighting (Koehn et al., 2003): lex( ¯f|¯e,a) = nproductdisplay i=1 1 |{j|(i, j) ∈ a}| summationdisplay ∀(i,j)∈a w(fi|ej) lex(¯e|¯f,a) = mproductdisplay j=1 1 |{i|(i, j) ∈ a}| summationdisplay ∀(i,j)∈a w(ej|fi) • phrase penalty: τ( ¯f|¯e) = e; log(τ( ¯f|¯e)) = 1 2.2 Decoding We used the Pharaoh decoder for both the Minimum Error Rate Training (Och, 2003) and test dataset decoding.
N03-1017 P03-1021
We retrained the parser on lowercased Penn Treebank II (Marcus et al., 1993), to match the lowercased output of the MT decoder.
J93-2004
The size of the development set used to generate λ1 and λ2 (1000 sentences) compensates the tendency of the unsmoothed MERT algorithm to overfit (Och, 2003) by providing a high ratio between number of variables and number of parameters to be estimated.
P03-1021
Although Phramer provides decoding functionality equivalent to Pharaoh’s, we preferred to use Pharaoh for this task because it is much faster than Phramer – between 2 and 15 times faster, depending on the configuration – and preliminary tests showed that there is no noticeable difference between the output of these two in terms of BLEU (Papineni et al., 2002) score.
P02-1040
Our system embeds Phramer2 (used for minimum error rate training, decoding, decoding tools), Pharaoh (Koehn, 2004) (decoding), Carmel 3 (helper for Pharaoh in n-best generation), Charniak’s parser (Charniak, 2001) (language model) and SRILM4 (n-gram LM construction).
P01-1017
6http://www.ldc.upenn.edu/Catalog/CatalogEntry.jsp? catalogId=LDC2005T12 151 sentence probability n-gram hit/miss model model 1-grams 310 K 310 K 2-grams 45 M 45 M 3-grams 123 M 283 M 4-grams 235 M 675 M Table 2: Number of n-gram entries in the EGW LM 2.4.2 Charniak parsing We used Charniak’s parser as an additional LM (Charniak, 2001) in reranking.
P01-1017
