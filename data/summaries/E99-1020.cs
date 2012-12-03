The set of items in a parsing system PAIg corresponding to the parsing schema Alg describing a given parsing algorithm Alg is denoted 2:Alg, the set of hypotheses 7/Alg, the set of final items ~'Alg and the set of deduction steps is denoted ~)Alg" 2 A CYK-like Algorithm We have chosen the CYK-like algorithm for TAG described in (Vijay-Shanker and Joshi, 1985) as our starting point.
P85-1011
The introduction of the element adj taking its value from the set {true, false} corrects the items previously proposed for this kind of algorithms in (Vijay-Shanker and Joshi, 1985) in order to avoid several adjunctions on a node.
P85-1011
As an additional advantage, the algorithm does not need to require the restriction that every auxiliary tree must have at least one terminal symbol in its frontier (Vijay-Shanker and Joshi, 1985).
P85-1011
M~u,i,j p',q'\] \[j, FZ -~ _k.,k,l I k,l\] • adj(M'r), p U p' andq U \[j, T --+ RZ.,j, rn ~~pkql!,,F~AdjComp o = \[h, M r --+ 5•, k, l \[ --Earley \[\[M'r --+ 5•, j, rn \[ p, q\]\] such that/3 E adj(M r) \[\[Mr j, m p, q\]l, \[h,F r -+ .l_.,p,q p,q\], ~AdiCompl' \[h, N r ~ 5 • M~u,i,j -, -\] ~'Earley = \[h, N~ ~ ~M~ • u, i, m I P, q\] such that/3 • adj(M r) \[\[M "r -+ 5.,j, rn \[ p,q\]\], q~AdjComp 2' \[h, Nr --+ 5* M'ru, i,j \[ p,q\] ~Earley = \[h, Nr -, • i, m I p, q\] such that/3 e adj(M r) ~)Scan -riPred I I =,F)Init LJ \[.J ~)Earley ~'Earley Earley ~" Earley'-' ~DCornp,F)Adj Pred 1"~FootPredl I Earley LJ ~Earley LJ ~JEarley v ~)FootCornp ~D AdjC°mp0 I,.J Earley I J Earley ~) AdjC°ml)ff I.J q")AdjC°mP'/ Earley ~Earley -~Earley = { \[0,7~ R ao,0,n I -,-\] I c~ • I } 6 Conclusion We have described a set of parsing algorithms for TAG creating a continuum which has the CYK-like parsing algorithm by (Vijay-Shanker and Joshi, 1985) as its starting point and the Earley-like parsing algorithm by (Nederhof, 1997) preserving the valid prefix property with time 156 Proceedings of EACL '99 complexity O(n 6) as its goal.
P85-1011
As a consequence, only one adjunction can take place on an elementary node, as is prescribed by the tree adjoining grammar formalism (Schabes and Shieber, 1994).
J94-1004
Several parsing algorithms have been proposed for this formalism, most of them based on tabular techniques, ranging from simple bottom-up algorithms (Vijay-Shanker and Joshi, 1985) to sophisticated extensions of the Earley's algorithm (Schabes and Joshi, 1988; Schabes, 1994; Nederhof, 1997).
J94-1004 P85-1011 P88-1032
\[j,-r -, R~,,j,m I k,1\], \[h,M ~ --+ vo, k,l lp, q\], \[h,F ~ -+ _L.,p,q p,q\], DadjCom p' = \[h, N ~ --+ 5 • M'rv, i, j -, -\] Earley \[h, N7 --~ 5M7 • u, i, m \[ p, q\] such that 13 E adj(M ~) \[j,T --+ R~*,j, m l k,l\], ih, M y --+ v',k,l -,-\],, T)AdjCornp 2 \[h,N'r -+ 5* M'rv, i,j if,q\] WEarley : \[h, N~ ~ 5M~ • v, i, m I P', q'\] such that \[3 E adj(M "y) ~DEarley ~D Init I.J ~D Scan LJ "FIPred II Earley Earley ~Earley ~ ~)Comp,/-)Adj Pred q-)FootPredl i Earley \['j ~Earley I.J ~Earley "-" ~)FootComp "/3 AdjC°mpl It q'~ AdjC°rnp2 Earley I J ~Earley "-" ~Earley 155 Proceedings of EACL '99 "DAdjC°mpl into Now, we must refine steps in '~'Earley ~) AdjC°mp° and ~) AdjC°mpff steps in Earley Earley, and req-)AdjComp ° q')AdjC°rnp2 into steps in ~Earley fine steps in,iEarley and q')AdjC°mp2' Correctness of these splittings ~Earley is guaranteed by the context-free property of TA G (Vijay-Shanker and Weir, 1993) establishing the independence of each adjunction with respect to any other adjunction.
J93-4002