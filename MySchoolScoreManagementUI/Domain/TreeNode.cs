using DevExpress.Xpf.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolScoreManagementUI.Domain
{
    public class TreeNode : ModelBase
    {
        public TreeNode(ModelBase model)
        {
            _model = model;
            Name = model.Name;
        }

        public ObservableCollection<TreeNode> SubNodes { get; set; } = new ObservableCollection<TreeNode>();

        private ModelBase _model;

        public ModelBase Model
        {
            get => _model;
            set => SetProperty(field: ref _model, value);
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                SetProperty(ref _isSelected, value);

                foreach (var subNode in SubNodes)
                {
                    subNode.IsSelected = value;
                }
            }
        }

        public void AddSubNode(TreeNode child)
        {
            if (!SubNodes.Contains(child))
                SubNodes.Add(child);
        }

        public void RemoveSubNode(TreeNode child)
        {
            if (SubNodes.Contains(child))
                SubNodes.Add(child);
        }
    }

    public class TreeChildSelector : IChildNodesSelector
    {
        public IEnumerable SelectChildren(object item)
        {
            if (item is TreeNode node)
                return node.SubNodes;

            return null;
        }
    }
 }
