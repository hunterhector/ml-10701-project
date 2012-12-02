Labels for Dependency Relations So far, the presented system, which follows closely the approach of McDonald et al.(2005), only predicts unlabelled dependency trees.
P05-1012
2.1 Parsing Algorithm In our approach, we adopt Eisner (1996)’s bottomup chart-parsing algorithm in McDonald et al.(2005)’s formulation, which finds the best projective dependency tree for an input string a0a2a1 a3a5a4a7a6a9a8a11a10a11a10a11a10a12a8a13a4a15a14a17a16. We assume that every possible head– dependent pair a18 a8a20a19 is described by a feature vector a21a23a22a25a24 with associated weights a26a27a22a28a24 . Eisner’s algorithm achieves optimal tree packing by storing partial structures in two matrices and . First the diagonals of the matrices are initiated with 0; then all other cells are filled according to eqs.
C96-1058 P05-1012
Having a closed–form solution, OPAL is easier to implement and more efficient than the MIRA algorithm used by McDonald et al.(2005), although it achieves a performance comparable to MIRA’s on many problems (Crammer et al., 2006).
P05-1012
Eisner. 1996.
C96-1058
We also investigated an extension, McDonald and Pereira (2006)’s second-order model, where more of the parsing history is taken into account, viz.
E06-1011
One promising approach is based on exact search and structural learning (McDonald et al., 2005; McDonald and Pereira, 2006).
E06-1011 P05-1012
In order to preserve the strength of McDonald et al.(2005)’s approach in terms of unlabelled attachment score, we add feature vectors for generalizations over deprels.
P05-1012
We essentially employ the same set of features as McDonald et al.(2005): a2a4a3 a22a28a24 a1 a5 w a22, fpa22, lcpa22, wa24, fpa24, lcpa24, wa22 wa24, wa22 lcpa24, lcpa22 wa24, lcpa22 lcpa24, fpa22 lcpa24, fpa22 fpa24, fpa22 fpa24 agra22a25a24, fpa22a7a6 a6 fpa22 fpa24a8a6 a6 fpa24, fpa22a9a6 a6 fpa22 fpa24 fpa24 a48 a6, fpa22 fpa22 a48 a6 fpa24a10a6 a6 fpa24, fp a22 fp a22 a48 a6 fp a24 fp a24 a48 a6a12a11, and token features for root words a2 a52a14a13 a1a15a5 wa13 a8 fp a13 a8 lcp a13 a11 . In the first order model, we recorded the tag of each tokena16 between a18 and a19 (a2 a22a25a24 a1 a2 a3a22a28a24a18a17 a5 fp a22 fp a24 fpa19 a11 ); in the second order model, we only conditioned on the previous dependent a56 (a2 a22a25a24 a1 a2 a3a22a28a24a20a17 a5 fp a22 fp a24 fpa40, lcpa22 fpa24 fpa40, wa22 fp a24 fpa40 a11 ).
P05-1012
and Results All experiments were conducted on the treebanks provided in the shared task (Hajiˇc et al., 2004; Aduriz et al., 2003; Martí et al., 2007; Chen et al., 2003; Böhmová et al., 2003; Marcus et al., 1993; Johansson and Nugues, 2007; Prokopidis et al., 2005; Csendes et al., 2005; Montemagni et al., 2003; Oflazer et al., 2003).
J93-2004
