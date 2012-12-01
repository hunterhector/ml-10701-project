Given the importance of this task for Natural Language Processing applications, several machine learning approaches for argument identification and classification have been developed (Gildea and Jurasky, 2002; Surdeanu et al., 2003; Hacioglu et al., 2003; Chen and Rambow, 2003; Gildea and Hockenmaier, 2003).
J02-3001 P02-1031 P03-1002 W03-1006 W03-1008
In (Collins and Duffy, 2002), it has been shown that Eq.
P02-1034
(Gildea and Palmer, 2002; Surdeanu et al., 2003; Hacioglu et al., 2003; Chen and Rambow, 2003; Gildea and Hockenmaier, 2003).
J02-3001 P02-1031 P03-1002 W03-1006 W03-1008
Experiments on PropBank data show not only that Support Vector Machines (SVMs) trained with the proposed semantic kernel converge but also that they have a higher accuracy than SVMs trained with a linear kernel on the standard features proposed in (Gildea and Jurasky, 2002).
J02-3001 P02-1031
Experiments For the experiments, we used PropBank (www.cis.upenn.edu/»ace) along with PennTreeBank5 2 (www.cis.upenn.edu/»treebank) (Marcus et al., 1993).
J93-2004
Semantic Kernel (SK) Given the semantic objects defined in the previous section, we design a convolution kernel in a way similar to the parse-tree kernel proposed in (Collins and Duffy, 2002).
P02-1034
This suggests that a combination of the flat features (especially the named entity class (Surdeanu et al., 2003)) with SK could furthermore improve the predicate argument representation.
P03-1002
An example of convolution kernel on the parse-tree space is given in (Collins and Duffy, 2002).
P02-1034
This corpus contains about 53,700 sentences and a fixed split between training and testing which has been used in other researches (Gildea and Jurasky, 2002; Surdeanu et al., 2003; Hacioglu et al., 2003; Chen and Rambow, 2003; Gildea and Hockenmaier, 2003; Gildea and Palmer, 2002; Pradhan et al., 2003).
J02-3001 P02-1031 P03-1002 W03-1006 W03-1008
and C4.5 are reported the results for argument classification achieved in (Gildea and Palmer, 2002) and (Surdeanu et al., 2003).
J02-3001 P02-1031 P03-1002 W03-1008
(Surdeanu et al., 2003), to improve the flat feature space.
P03-1002
These standard features, firstly proposed in (Gildea and Jurasky, 2002), refer to a flat information derived from parse trees, i.e.
J02-3001 P02-1031
Finally, there is a considerable work in Natural Language Processing oriented kernel (Collins and Duffy, 2002; Lodhi et al., 2000; G¨artner, 2003; Cumby and Roth, 2003; Zelenko et al., 2003) about string, parse7More precisely, it is O(jFp;aj2) where Fp;a is the largest semantic structure of the training data.
P02-1034
For this purpose a parameter ‚ is introduced in equations 2 and 3 obtaining: ∆(nx;nz) = ‚ (4) ∆(nx;nz) = ‚ nc(nx)Y j=1 (1+∆(ch(nx;j);ch(nz;j))) (5) It is worth noting that even if the above equations define a kernel function similar to the one proposed in (Collins and Duffy, 2002), the substructures on which SK operates are different from the parse-tree kernel.
P02-1034
