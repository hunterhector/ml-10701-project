A Experimental Setup Following the usual conventions (Klein and Manning, 2002), our experiments use treebank POS sequences of length ≤ 10, stripped of words and punctuation.
P02-1017
The only difference is that we 5See also work on partial parsing as a task in its own right: Hindle (1990) inter alia.
P90-1034
fifth column of Table 3).8 6 Comparison and Combination with Contrastive Estimation Contrastive estimation (CE) was recently introduced (Smith and Eisner, 2005a) as a class of alternatives to the likelihood objective function locally maximized by EM.
H05-1050 P05-1044 W05-1504
This method was applied with some success to grammar induction models by Smith and Eisner (2004).
P04-1062
before. Four of the languages have at least one effective CE condition, supporting our previous English results (Smith and Eisner, 2005b), but CE was harmful for Bulgarian and Mandarin.
H05-1050 P05-1044 W05-1504
Our training datasets are: • 8,227 German sentences from the TIGER Treebank (Brants et al., 2002), • 5,301 English sentences from the WSJ Penn Treebank (Marcus et al., 1993), • 4,929 Bulgarian sentences from the BulTreeBank (Simov et al., 2002; Simov and Osenova, 2003; Simov et al., 2004), • 2,775 Mandarin sentences from the Penn Chinese Treebank (Xue et al., 2004), • 2,576 Turkish sentences from the METUSabanci Treebank (Atalay et al., 2003; Oflazer et al., 2003), and • 1,676 Portuguese sentences from the Bosque portion of the Floresta Sint´a(c)tica Treebank (Afonso et al., 2002).
J93-2004
In §6 we briefly review contrastive estimation (Smith and Eisner, 2005a), relating it to the new method, and show its performance alone and when augmented with structural bias.
H05-1050 P05-1044 W05-1504
Eisner and Smith (2005) achieved speed and accuracy improvements by modeling distance directly in a ML-estimated (deficient) generative model.
H05-1050 P05-1044 W05-1504
Eisner. 2005b.
H05-1050 W05-1504
The technique bears some similarity to the estimation methods described by Brown et al.(1993), which started by estimating simple models, using each model to seed the next.
J93-2003
In earlier work, Brill and Marcus (1992) adopted a “local first” iterative merge strategy for discovering phrase structure.
H92-1030
Bootstrapping was applied to syntax learning by Steedman et al.(2003). Our approach differs in being able to remain partly agnostic about each tag’s true parent (e.g., by giving 50% probability to attaching to $), whereas Steedman et al.make a hard decision to retrain on a whole sentence fully or leave it out fully.
E03-1008
We relate this approach to contrastive estimation (Smith and Eisner, 2005a), apply the latter to grammar induction in six languages, and show that our new approach improves accuracy by 1–17% (absolute) over CE (and 8–30% over EM), achieving to our knowledge the best results on this task to date.
H05-1050 P05-1044 W05-1504
Smith and Jason Eisner Department of Computer Science / Center for Language and Speech Processing Johns Hopkins University, Baltimore, MD 21218 USA {nasmith,jason}@cs.jhu.edu Abstract We first show how a structural locality bias can improve the accuracy of state-of-the-art dependency grammar induction models trained by EM from unannotated examples (Klein and Manning, 2004).
P04-1061
The Bulgarian, Turkish, and Portuguese datasets come from the CoNLL-X shared task (Buchholz and Marsi, 2006); we thank the organizers.
W06-2920
and Model In this paper we use a simple unlexicalized dependency model due to Klein and Manning (2004).
P04-1061
Ideally one would like to select values simultaneously for many hyperparameters, perhaps using a small annotated corpus (as done here), extrinsic figures of merit on successful learning trajectories, or plausibility criteria (Eisner and Karakos, 2005).
H05-1050 W05-1504
In supervised dependency parsing, Eisner and Smith (2005) showed that imposing a hard constraint on the whole structure— specifically that each non-$ dependency arc cross fewer than k words—can give guaranteed O(nk2) runtime with little to no loss in accuracy (for simple models).
H05-1050 P05-1044 W05-1504
The model is a probabilistic head automaton grammar (Alshawi, 1996) with a “split” form that renders it parseable in cubic time (Eisner, 1997).
P96-1023
Work One weakness of all recent weighted grammar induction work—including Klein and Manning (2004), Smith and Eisner (2005b), and the present paper—is a sensitivity to hyperparameters, including smoothing values, choice of N (for CE), and annealing schedules—not to mention initialization.
H05-1050 P04-1061 P05-1044 W05-1504
This was done for supervised parsing in different ways by Collins (1997), Klein and Manning (2003), and McDonald et al.(2005), all of whom considered intervening material or coarse distance classes when predicting children in a tree.
P05-1012 P97-1003
Annealing β resembles the popular bootstrapping technique (Yarowsky, 1995), which starts out aiming for high precision, and gradually improves coverage over time.
P95-1026
Eisner. 2005a.
H05-1050 W05-1504
6See Eisner and Satta (1999) for the relevant algorithm used in the experiments.
P99-1059
CE was found to outperform EM on the task of focus in this paper, when applied to English data (Smith and Eisner, 2005b).
H05-1050 P05-1044 W05-1504
