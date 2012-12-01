Of particular relevance to MT is the issue of struc452 tural divergence (Dorr, 1994).
J94-4004
For each setting, we trained in both directions and combined the two alignments by taking the intersection, union, and refined as defined in (Och and Ney, 2000).
P00-1056
In particular, knowing a little about the structure of a language can help in developing annotated corpora and tools, since a little knowledge can go a long way in inducing accurate structure and annotations (Haghighi and Klein, 2006).
N06-1041
It is also possible that small samples of data showing the alignment interactionsbetween sourcelanguagestructuresandthose of English can provide essential bootstrap information for informing machine translation systems (cf (Quirk and Corston-Oliver, 2006)).
W06-1608
We then train IBM models (Brown et al., 1993) using the GIZA++ package (Och and Ney, 2000).
J93-2003 P00-1056
In the third step, we keep only the copy that is closest to the root and remove all the other copies.7 In Step 4, we attach unaligned source words to the DS using the heuristics described in (Quirk et al., 2005).
P05-1034
word aligner Our second word aligner is based on the assumption that if two words(one on the glossline, the other on the translationline) havethe sameroot form, they are likely to be aligned to one other.We built a simple English morphological analyzer and ran it on the two lines, and then linked the words with the same 454 root form.4 3.3 Tree projection We designed two projection algorithms: one which projects PS and the other which projects DS, both from the English to the source language.5 3.3.1 Projecting dependency structure Our DS projection algorithm is similar to the projection algorithmsdescribedin (Hwaetal., 2002)and (Quirk et al., 2005).
P02-1050 P05-1034
Mitchell Marcus, Grace Kim, Mary Ann Marcinkiewicz, et al.1994. The Penn Treebank: Annotating Predicate Argument Structure.
H94-1020
English sentences There are many English parsers available to the public, and in this experiment we used Charniak’s parser (Charniak, 1997), which was trained on the English Penn Treebank (Marcus et al., 1994).
H94-1020
For instance, we plan to extract transfer rules from the aligned source and English structures and also calculate head/modifier crossings between languages similar to those described in (Fox, 2002).
W02-1039
The order of constituents, for instance, can be used to inform prototype-driven learning strategies (Haghighi and Klein, 2006), which can then be applied to raw corpora.
N06-1041
Given a parse tree, we use a head percolation table (Magerman, 1995) to create the corresponding dependency structure.
P95-1037
Dorr. 1994.
J94-4004
Some notable efforts have been undertaken to develop automated means for creating annotated corpora through the projection of annotations (Yarowksy and Ngai, 2001; Xi and Hwa, 2005).
H05-1107
However, to what extent that assumption holds is tested only on a small number of language pairs using hand aligned data (Fox, 2002; Hwa et al., 2002; Wellington et al., 2006).
P02-1050 P06-1123 W02-1039
Many MT models implicitly make the so-called direct correspondence assumption (DCA) as defined in (Hwa et al., 2002).
P02-1050
Magerman. 1995.
P95-1037
