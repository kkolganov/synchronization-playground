
namespace SynchronizationPlayground
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnUnsynchronized = new Button();
            btnLockSynchronized = new Button();
            btnUnsyncWorkBlock = new Button();
            btnLockSyncWorkBlock = new Button();
            btnSemaphoredWorkBlock = new Button();
            btnSpinnerSyncBlock = new Button();
            btnSpinWaitWorkBlock = new Button();
            btnPulseWaitSync = new Button();
            btnResetEventsyncWorkBlock = new Button();
            btnAutoResetEventWorkBlock = new Button();
            btnBarrierSyncWorkBlock = new Button();
            btnReadWriteSync = new Button();
            btnUnsyncReadWrite = new Button();
            btnAsyncAwaitSequential = new Button();
            btnAsyncAwaitBreakfastParallel = new Button();
            btnInterlockedExample = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(211, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome, please, make your selection:";
            // 
            // btnUnsynchronized
            // 
            btnUnsynchronized.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnUnsynchronized.Location = new Point(12, 27);
            btnUnsynchronized.Name = "btnUnsynchronized";
            btnUnsynchronized.Size = new Size(354, 23);
            btnUnsynchronized.TabIndex = 1;
            btnUnsynchronized.Text = "Unsynchronized threads";
            btnUnsynchronized.UseVisualStyleBackColor = true;
            btnUnsynchronized.Click += btnUnsynchronized_Click;
            // 
            // btnLockSynchronized
            // 
            btnLockSynchronized.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLockSynchronized.Location = new Point(12, 56);
            btnLockSynchronized.Name = "btnLockSynchronized";
            btnLockSynchronized.Size = new Size(354, 23);
            btnLockSynchronized.TabIndex = 2;
            btnLockSynchronized.Text = "Synchronized with lock";
            btnLockSynchronized.UseVisualStyleBackColor = true;
            btnLockSynchronized.Click += btnLockSynchronized_Click;
            // 
            // btnUnsyncWorkBlock
            // 
            btnUnsyncWorkBlock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnUnsyncWorkBlock.Location = new Point(12, 85);
            btnUnsyncWorkBlock.Name = "btnUnsyncWorkBlock";
            btnUnsyncWorkBlock.Size = new Size(354, 23);
            btnUnsyncWorkBlock.TabIndex = 3;
            btnUnsyncWorkBlock.Text = "Unsynchronized work block";
            btnUnsyncWorkBlock.UseVisualStyleBackColor = true;
            btnUnsyncWorkBlock.Click += btnUnsyncWorkBlock_Click;
            // 
            // btnLockSyncWorkBlock
            // 
            btnLockSyncWorkBlock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLockSyncWorkBlock.Location = new Point(12, 114);
            btnLockSyncWorkBlock.Name = "btnLockSyncWorkBlock";
            btnLockSyncWorkBlock.Size = new Size(354, 23);
            btnLockSyncWorkBlock.TabIndex = 4;
            btnLockSyncWorkBlock.Text = "Lock-synchronized work block";
            btnLockSyncWorkBlock.UseVisualStyleBackColor = true;
            btnLockSyncWorkBlock.Click += btnLockSyncWorkBlock_Click;
            // 
            // btnSemaphoredWorkBlock
            // 
            btnSemaphoredWorkBlock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSemaphoredWorkBlock.Location = new Point(12, 143);
            btnSemaphoredWorkBlock.Name = "btnSemaphoredWorkBlock";
            btnSemaphoredWorkBlock.Size = new Size(354, 23);
            btnSemaphoredWorkBlock.TabIndex = 5;
            btnSemaphoredWorkBlock.Text = "Semaphore-synchronized work block";
            btnSemaphoredWorkBlock.UseVisualStyleBackColor = true;
            btnSemaphoredWorkBlock.Click += btnSemaphoredWorkBlock_Click;
            // 
            // btnSpinnerSyncBlock
            // 
            btnSpinnerSyncBlock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSpinnerSyncBlock.Location = new Point(12, 172);
            btnSpinnerSyncBlock.Name = "btnSpinnerSyncBlock";
            btnSpinnerSyncBlock.Size = new Size(354, 23);
            btnSpinnerSyncBlock.TabIndex = 6;
            btnSpinnerSyncBlock.Text = "Spinner-synchronized work block";
            btnSpinnerSyncBlock.UseVisualStyleBackColor = true;
            btnSpinnerSyncBlock.Click += btnSpinnerSyncBlock_Click;
            // 
            // btnSpinWaitWorkBlock
            // 
            btnSpinWaitWorkBlock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSpinWaitWorkBlock.Location = new Point(12, 201);
            btnSpinWaitWorkBlock.Name = "btnSpinWaitWorkBlock";
            btnSpinWaitWorkBlock.Size = new Size(354, 23);
            btnSpinWaitWorkBlock.TabIndex = 7;
            btnSpinWaitWorkBlock.Text = "SpinWait-synchronized work block";
            btnSpinWaitWorkBlock.UseVisualStyleBackColor = true;
            btnSpinWaitWorkBlock.Click += btnSpinWaitWorkBlock_Click;
            // 
            // btnPulseWaitSync
            // 
            btnPulseWaitSync.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPulseWaitSync.Location = new Point(12, 230);
            btnPulseWaitSync.Name = "btnPulseWaitSync";
            btnPulseWaitSync.Size = new Size(354, 23);
            btnPulseWaitSync.TabIndex = 8;
            btnPulseWaitSync.Text = "Pulse/Wait synchronized work block";
            btnPulseWaitSync.UseVisualStyleBackColor = true;
            btnPulseWaitSync.Click += btnPulseWaitSync_Click;
            // 
            // btnResetEventsyncWorkBlock
            // 
            btnResetEventsyncWorkBlock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnResetEventsyncWorkBlock.Location = new Point(12, 259);
            btnResetEventsyncWorkBlock.Name = "btnResetEventsyncWorkBlock";
            btnResetEventsyncWorkBlock.Size = new Size(354, 23);
            btnResetEventsyncWorkBlock.TabIndex = 9;
            btnResetEventsyncWorkBlock.Text = "Manual reset event synchronized work block";
            btnResetEventsyncWorkBlock.UseVisualStyleBackColor = true;
            btnResetEventsyncWorkBlock.Click += btnResetEventsyncWorkBlock_Click;
            // 
            // btnAutoResetEventWorkBlock
            // 
            btnAutoResetEventWorkBlock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAutoResetEventWorkBlock.Location = new Point(12, 288);
            btnAutoResetEventWorkBlock.Name = "btnAutoResetEventWorkBlock";
            btnAutoResetEventWorkBlock.Size = new Size(354, 23);
            btnAutoResetEventWorkBlock.TabIndex = 10;
            btnAutoResetEventWorkBlock.Text = "Auto reset event synchronized work block";
            btnAutoResetEventWorkBlock.UseVisualStyleBackColor = true;
            btnAutoResetEventWorkBlock.Click += btnAutoResetEventWorkBlock_Click;
            // 
            // btnBarrierSyncWorkBlock
            // 
            btnBarrierSyncWorkBlock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBarrierSyncWorkBlock.Location = new Point(12, 317);
            btnBarrierSyncWorkBlock.Name = "btnBarrierSyncWorkBlock";
            btnBarrierSyncWorkBlock.Size = new Size(354, 23);
            btnBarrierSyncWorkBlock.TabIndex = 11;
            btnBarrierSyncWorkBlock.Text = "Barrier-synchronized work block";
            btnBarrierSyncWorkBlock.UseVisualStyleBackColor = true;
            btnBarrierSyncWorkBlock.Click += btnBarrierSyncWorkBlock_Click;
            // 
            // btnReadWriteSync
            // 
            btnReadWriteSync.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnReadWriteSync.Location = new Point(12, 346);
            btnReadWriteSync.Name = "btnReadWriteSync";
            btnReadWriteSync.Size = new Size(354, 23);
            btnReadWriteSync.TabIndex = 12;
            btnReadWriteSync.Text = "Read-write synchronization";
            btnReadWriteSync.UseVisualStyleBackColor = true;
            btnReadWriteSync.Click += btnReadWriteSync_Click;
            // 
            // btnUnsyncReadWrite
            // 
            btnUnsyncReadWrite.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnUnsyncReadWrite.Location = new Point(12, 375);
            btnUnsyncReadWrite.Name = "btnUnsyncReadWrite";
            btnUnsyncReadWrite.Size = new Size(354, 23);
            btnUnsyncReadWrite.TabIndex = 13;
            btnUnsyncReadWrite.Text = "Unsynchronized read-write";
            btnUnsyncReadWrite.UseVisualStyleBackColor = true;
            btnUnsyncReadWrite.Click += btnUnsyncReadWrite_Click;
            // 
            // btnAsyncAwaitSequential
            // 
            btnAsyncAwaitSequential.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAsyncAwaitSequential.Location = new Point(12, 433);
            btnAsyncAwaitSequential.Name = "btnAsyncAwaitSequential";
            btnAsyncAwaitSequential.Size = new Size(354, 23);
            btnAsyncAwaitSequential.TabIndex = 14;
            btnAsyncAwaitSequential.Text = "Async/Await breakfast, but sequential";
            btnAsyncAwaitSequential.UseVisualStyleBackColor = true;
            btnAsyncAwaitSequential.Click += btnAsyncAwaitSequential_Click;
            // 
            // btnAsyncAwaitBreakfastParallel
            // 
            btnAsyncAwaitBreakfastParallel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAsyncAwaitBreakfastParallel.Location = new Point(12, 462);
            btnAsyncAwaitBreakfastParallel.Name = "btnAsyncAwaitBreakfastParallel";
            btnAsyncAwaitBreakfastParallel.Size = new Size(354, 23);
            btnAsyncAwaitBreakfastParallel.TabIndex = 15;
            btnAsyncAwaitBreakfastParallel.Text = "Async/Await breakfast, but parallel";
            btnAsyncAwaitBreakfastParallel.UseVisualStyleBackColor = true;
            btnAsyncAwaitBreakfastParallel.Click += btnAsyncAwaitBreakfastParallel_Click;
            // 
            // btnInterlockedExample
            // 
            btnInterlockedExample.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnInterlockedExample.Location = new Point(12, 404);
            btnInterlockedExample.Name = "btnInterlockedExample";
            btnInterlockedExample.Size = new Size(354, 23);
            btnInterlockedExample.TabIndex = 16;
            btnInterlockedExample.Text = "Interlocked counter example";
            btnInterlockedExample.UseVisualStyleBackColor = true;
            btnInterlockedExample.Click += btnInterlockedExample_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 497);
            Controls.Add(btnInterlockedExample);
            Controls.Add(btnAsyncAwaitBreakfastParallel);
            Controls.Add(btnAsyncAwaitSequential);
            Controls.Add(btnUnsyncReadWrite);
            Controls.Add(btnReadWriteSync);
            Controls.Add(btnBarrierSyncWorkBlock);
            Controls.Add(btnAutoResetEventWorkBlock);
            Controls.Add(btnResetEventsyncWorkBlock);
            Controls.Add(btnPulseWaitSync);
            Controls.Add(btnSpinWaitWorkBlock);
            Controls.Add(btnSpinnerSyncBlock);
            Controls.Add(btnSemaphoredWorkBlock);
            Controls.Add(btnLockSyncWorkBlock);
            Controls.Add(btnUnsyncWorkBlock);
            Controls.Add(btnLockSynchronized);
            Controls.Add(btnUnsynchronized);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Main";
            Text = "Synchronization Playground";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnUnsynchronized;
        private Button btnLockSynchronized;
        private Button btnUnsyncWorkBlock;
        private Button btnLockSyncWorkBlock;
        private Button btnSemaphoredWorkBlock;
        private Button btnSpinnerSyncBlock;
        private Button btnSpinWaitWorkBlock;
        private Button btnPulseWaitSync;
        private Button btnResetEventsyncWorkBlock;
        private Button btnAutoResetEventWorkBlock;
        private Button btnBarrierSyncWorkBlock;
        private Button btnReadWriteSync;
        private Button btnUnsyncReadWrite;
        private Button btnAsyncAwaitSequential;
        private Button btnAsyncAwaitBreakfastParallel;
        private Button btnInterlockedExample;
    }
}
