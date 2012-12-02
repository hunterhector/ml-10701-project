Several machine learning approaches for argument identi cation and classi cation have been developed (Gildea and Jurasfky, 2002; Gildea and Palmer, 2002; Surdeanu et al., 2003; Hacioglu et al., 2003).
J02-3001 P02-1031 P03-1002
We note that (a) the highest performance is reached for d = 3, (b) for PropBank our maximal accuracy (90.5%) 7f1 assigns equal importance to Precision P and Recall R, i.e. f1 = 2P RP+R . is substantially equal to the SVM performance (88%) obtained in (Hacioglu et al., 2003) with degree 2 and (c) the accuracy on FrameNet (85.2%) is higher than the best result obtained in literature, i.e. 82.0% in (Gildea and Palmer, 2002).
J02-3001 P02-1031
In (Collins and Du y, 2002), it has been shown that Pi Ii(nx)Ii(nz) = (nx;nz) can be computed in O(jNxj jNzj) by the following recursive relation: (1) if the productions at nx and nz are di erent then (nx;nz) = 0; 2A fragment can appear several times in a parse-tree, thus each fragment occurrence is considered as a di erent element in F 0p;a.
P02-1034
PropBank contains about 53,700 sentences and a xed split between training and testing which has been used in other researches e.g., (Gildea and Palmer, 2002; Surdeanu et al., 2003; Hacioglu et al., 2003).
J02-3001 P02-1031 P03-1002
The sentences were processed using Collins’ parser (Collins, 1997) to generate parse-trees automatically.
P97-1003
(Gildea and Jurasfky, 2002; Surdeanu et al., 2003; Hacioglu et al., 2003).
J02-3001 P02-1031 P03-1002
set-up The above kernels were experimented over two corpora: PropBank (www.cis.upenn.edu/ ace) along with Penn TreeBank5 2 (Marcus et al., 1993) and FrameNet.
J93-2004
This kind of kernel has the drawback of assigning more weight to larger structures while the argument type does not strictly depend on the size of the argument (Moschitti and Bejan, 2004).
W04-2403
3.3 Predicate/Argument structure Kernel (PAK) Given the semantic objects de ned in the previous section, we design a convolution kernel in a way similar to the parse-tree kernel proposed in (Collins and Du y, 2002).
P02-1034
It is worth noting that even if the above equations de ne a kernel function similar to the one proposed in (Collins and Du y, 2002), the substructures on which it operates are di erent from the parse-tree kernel.
P02-1034
These standard features, rstly proposed in (Gildea and Jurasfky, 2002), refer to a at information derived from parse trees, i.e.
J02-3001 P02-1031
