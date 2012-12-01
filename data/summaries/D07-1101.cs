The second-order model of McDonald and Pereira (2006) considers 〈h, m, ch〉.
E06-1011
The first-order features φ1(x, h, m) are the exact same implementation as in previous CoNLL system (Carreras et al., 2006).
W06-2925
Algorithm In this section we sketch an extension of the projective dynamic programming algorithm of Eisner (1996; 2000) for the higher-order model defined above.
C96-1058
In turn, those features were inspired by successful previous work in firstorder dependency parsing (McDonald et al., 2005).
P05-1012
As for the second-order features, we again base our features with those of McDonald and Pereira (2006), who reported successful experiments with second-order models.
E06-1011
We extend the projective parsing algorithm of Eisner (1996) for our case, and train models using the averaged perceptron.
C96-1058
In the multilingual exercise of the CoNLL-2007 shared task (Nivre et al., 2007), our system obtains the best accuracy for English, and the second best accuracies for Basque and Czech.
D07-1096
Eisner. 1996.
C96-1058
Specifically, these approaches considered sibling relations of the modifier token (Eisner, 1996; McDonald and Pereira, 2006).
C96-1058 E06-1011
The definition of φ2(x, h, m, c) is: • dir · cpos(xh) · cpos(xm) · cpos(xc) • dir · cpos(xh) · cpos(xc) • dir · cpos(xm) · cpos(xc) • dir · form(xh) · form(xc) • dir · form(xm) · form(xc) • dir · cpos(xh) · form(xc) • dir · cpos(xm) · form(xc) • dir · form(xh) · cpos(xc) • dir · form(xm) · cpos(xc) 3 Experiments and Results We report experiments with higher-order models for the ten languages in the multilingual track of the CoNLL-2007 shared task (Nivre et al., 2007).1 In all experiments, we trained our models using the averaged perceptron (Freund and Schapire, 1999), following the extension of Collins (2002) for structured prediction problems.
D07-1096 W02-1001
The second model is similar to that of McDonald and Pereira (2006): a factor consists of a main labeled dependency and the head child closest to the modifier (ch).
E06-1011
(Ratnaparkhi et al., 1994).
H94-1048
To train models, we used “projectivized” versions of the training dependency trees.2 1We are grateful to the providers of the treebanks that constituted the data for the shared task (Hajiˇc et al., 2004; Aduriz et al., 2003; Mart´ı et al., 2007; Chen et al., 2003; B¨ohmov´a et al., 2003; Marcus et al., 1993; Johansson and Nugues, 2007; Prokopidis et al., 2005; Csendes et al., 2005; Montemagni et al., 2003; Oflazer et al., 2003).
J93-2004
