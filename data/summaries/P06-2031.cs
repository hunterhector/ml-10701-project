These methods look at the context words and discourse surrounding the source word and use methods ranging from boostrapping (Li & Li 2003), EM iterations (Cao and Li, 2002; Koehn and Knight 2000), and the cohesive relation between the source sentence and translation candidates (Fung et al.1999; Kikui 1999).
C02-1011 P99-1043
Our method improves word sense translation precision over Fung and Chen (2004).
C04-1134 P04-1038
FrameNet (Baker et al.1998) is a collection of lexical entries grouped by frame semantics.
P98-1013
Work The most relevant previous works include word sense translation and translation disambiguation (Li & Li 2003; Cao & Li 2002; Koehn and Knight 2000; Kikui 1999; Fung et al., 1999), frame semantic induction (Green et al., 2004; Fung & Chen 2004), and bilingual semantic mapping (Fung & Chen 2004; Huang et al.2004; Ploux & Ji, 2003, Ngai et al., 2002; Palmer & Wu 1995).
C02-1011 C02-1162 C04-1134 J03-2001 P04-1038 P04-1048 P99-1043
Automatic Generation of Frame Semantics Green et al.(2004) induced SemFrame automatically and compared it favorably to the handconstructed FrameNet (83.2% precision in covering the FrameNet frames).
P04-1048
In Fung and Chen (2004), semantic frames are mapped to each other if their lexical entries translate to each other above a certain threshold.
C04-1134 P04-1038
We note in particular that whereas the previous algorithm in Fung and Chen (2004) does not 1 We are not able to evaluate our algorithm on the same set of words as in (Li & Li 2003; Yarowsky 1995) since these words do not have entries in FrameNet.
C04-1134 P04-1038
Our results also compare favorably to (Fung et al.1999; Kikui 1999) as the precision of our predicate verb in the input sentence translation disambiguation is about 75% whereas their precisions range from 40% to 80%, albeit on an independent set of words.
P99-1043
lexical entry Parent frame Accuracy (Fung & Chen 2004) Accuracy (this paper) beat.v cause_harm 88.9% 100% move.v motion 100% 100% bright.a light_emission 79.1% 100% hold.v containing 22.4% 100% fall.v motion_directional 87% 100% issue.v emanating 31.1% 100% Table 3.
C04-1134 P04-1038
Translation accuracies of the most ambiguous words in FrameNet We compare our results to that of our previous work (Fung and Chen 2004), by using the same bilingual lexicon.
C04-1134 P04-1038
Other than the English FrameNet (Baker et al, 1998), we also note the construction of the Spanish FrameNet (Subirats & Petruck, 2003), the Japanese FrameNet (Ikeda 1998), and the German FrameNet (Boas, 2002).
P98-1013
In particular, for languages as different as English and Chinese, there is little overlap between how lexicon is broken-down (Ploux and Ji 2003).
J03-2001
In terms of learning method, Chen and Palmer (2004) also used EM learning to cluster Chinese verb senses.
P04-1038
Ngai et al.(2002) induced bilingual semantic network from WordNet and HowNet.
C02-1162
It would be necessary to apply either semiautomatic or automatic methods such as those in (Burchardt et al.2005, Green et al 2004) to extend FrameNet coverage for final application to machine translation tasks.
P04-1048
An example bilingual frame We previously proposed using the Chinese HowNet and a bilingual lexicon to map the English FrameNet into a bilingual BiFrameNet (Fung and Chen 2004).
C04-1134 P04-1038
The Berkeley FrameNet (Baker et al.1998) is such an example.
P98-1013
Daniel Gildea and Daniel Jurafsky.(2002).Automatic Labeling of Semantic Roles.
J02-3001
Bilingual Semantic Mapping Ploux and Ji, (2003) proposed a spatial model for matching semantic values between French and English.
J03-2001
