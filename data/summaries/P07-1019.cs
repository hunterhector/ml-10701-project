For cube growing, we use a non-duplicate k-best method (Huang et al., 2006) to get 100-best unique translations according to −LM to estimate the lower-bound heuristics.4 This preprocessing step takes on average 0.12 seconds per sentence, which is negligible in comparison to the +LM decoding time.
W06-3601
We push the idea behind this method further and make the following contributions in this paper: • We generalize cube pruning and adapt it to two systems very different from Hiero: a phrasebased system similar to Pharaoh (Koehn, 2004) and a tree-to-string system (Huang et al., 2006).
W06-3601
5.2 Tree-to-string Decoding In tree-to-string (also called syntax-directed) decoding (Huang et al., 2006; Liu et al., 2006), the source string is first parsed into a tree, which is then recursively converted into a target string according to transfer rules in a synchronous grammar (Galley et al., 2006).
P06-1077 P06-1121 W06-3601
This new method, called cube growing, is a lazy version of cube pruning just as Algorithm 3 of Huang and Chiang (2005), is a lazy version of Algorithm 2 (see Table 1).
P05-1033 W05-1506
We test our methods on two large-scale English-toChinese translation systems: a phrase-based system and our tree-to-string system (Huang et al., 2006).
W06-3601
This situation is very similar to kbest parsing and we can adapt the Algorithm 2 of Huang and Chiang (2005) here to explore this grid in a best-first order.
P05-1033 W05-1506
Since our tree-to-string rules may have many variables, we first binarize each hyperedge in the forest on the target projection (Huang, 2007).
W07-0405
a Language Model To integrate with a bigram language model, we can use the dynamic-programming algorithms of Och and Ney (2004) and Wu (1996) for phrase-based and SCFG-based systems, respectively, which we may think of as doing a finer-grained version of the deductions above.
J04-4002 P96-1021
We use the same test set as (Huang et al., 2006), which is a 140-sentence subset of the NIST 2003 test set with 9–36 words on the English side.
W06-3601
The data set is same as in Section 5.1, except that we also parsed the English-side using a variant of the Collins (1997) parser, and then extracted 24.7M tree-to-string rules using the algorithm of (Galley et al., 2006).
P06-1121 P97-1003
programming (Wu, 1996; Och and Ney, 2004).
J04-4002 P96-1021
• We also devise a faster variant of cube pruning, called cube growing, which uses a lazy version of k-best parsing (Huang and Chiang, 2005) that tries to reduce k to the minimum needed at each node to obtain the desired number of hypotheses at the root.
P05-1033 W05-1506
Our data preparation follows Huang et al.(2006): the training data is a parallel corpus of 28.3M words on the English side, and a trigram language model is trained on the Chinese side.
W06-3601
By adapting the k-best parsing Algorithm 2 of Huang and Chiang (2005), it achieves significant speed-up over full-integration on Chiang’s Hiero system.
P05-1033 W05-1506
Part of the complexity arises from the expressive power of the translation model: for example, a phraseor word-based model with full reordering has exponential complexity (Knight, 1999).
J99-4005
Recent efforts in statistical machine translation (MT) have seen promising improvements in output quality, especially the phrase-based models (Och and Ney, 2004) and syntax-based models (Chiang, 2005; Galley et al., 2006).
J04-4002 P05-1033 P06-1121
These forest rescoring algorithms have potential applications to other computationally intensive tasks involving combinations of different models, for example, head-lexicalized parsing (Collins, 1997); joint parsing and semantic role labeling (Sutton and McCallum, 2005); or tagging and parsing with nonlocal features.
P97-1003 W05-0636
In a nutshell, cube pruning works on the −LM forest, keeping at most k +LM items at each node, and uses the k-best parsing Algorithm 2 of Huang and Chiang (2005) to speed up the computation.
P05-1033 W05-1506
